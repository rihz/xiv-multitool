using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Common;
using XIVChecklist.Entities.Tasks.GameLogs;

namespace XIVChecklist.Data.Seed
{
    public class HuntingLogSeedling : Seedling
    {
        public HuntingLogSeedling(string name)
            : base(name, "Hunting Logs")
        { }
    }

    public class HuntingLogSeed : Seed<HuntingLogTask>, ISeed<HuntingLogTask>
    {
        public Seedling[] Seedlings
        {
            get
            {
                return new Seedling[]
                {
                    new HuntingLogSeedling("Hunting")
                };
            }
        }

        public Stream GetResource(string name)
        {
            return GetResourceStream("Logs", name);
        }

        public IEnumerable<HuntingLogTask> Parse(Stream resource, Seedling seedling, ref int id)
        {
            var tasks = new List<HuntingLogTask>();
            var ctr = id;
            var parse = ParseResource<HuntingLogParse>(resource);
            var mobId = 1;

            tasks.AddRange(parse.Select((x, index) =>
            {
                var task = new HuntingLogTask
                {
                    Id = ++ctr,
                    Name = x.Record,
                    CategoryId = seedling.CategoryId,
                    HuntingLogTypeId = SeedCommon.GetHuntingLogTypeId(x.Record.Split(' ')[0]),
                    Level = x.Level,
                    Number = x.Record.Split(' ')[x.Record.Split(' ').Length - 1]
                };

                var mobNames = x.Mobs.Split(',');
                var zoneNames = x.Zone.Split(',');
                var locationNames = x.Location.Split(';');
                var mobs = new List<HuntingLogMob>();

                for (var i = 0; i < mobNames.Count(); i++)
                {
                    var name = "";
                    var zoneName = "";
                    var location = "";
                    var locationName = "";
                    var coordinates = new string[] { "" };
                    
                    try
                    {
                        name = mobNames[i].Trim();

                        zoneName = zoneNames.Length >= i + 1
                            ? zoneNames[i].Trim()
                            : zoneNames[zoneNames.Length - 1].Trim();

                        location = locationNames.Length >= i + 1
                            ? locationNames[i].Trim()
                            : locationNames[locationNames.Length - 1].Trim();

                        locationName = location.Split('(')[0].Trim();

                        coordinates = location.Split('(', ')').Length > 1
                            ? location.Split('(', ')')[1].Split(',')
                            : new string[] { "-1", "-1" };

                        mobs.Add(new HuntingLogMob
                        {
                            Id = mobId++,
                            Name = name,
                            Zone = zoneName,
                            Location = locationName,
                            X = decimal.Parse(coordinates[0]),
                            Y = decimal.Parse(coordinates[1]),
                            HuntingLogId = ctr
                        });
                    }
                    catch(Exception ex)
                    {
                        throw new Exception(string.Format("Exception item: {0}", mobNames[0]));
                    }
                    //catch(FormatException ex)
                    //{
                    //    throw new Exception(string.Format("Format Exception. Name: {0}, X: {1}, Y: {2}", name, coordinates[0].Trim(), coordinates[1].Trim()));
                    //}
                    //catch(IndexOutOfRangeException ex)
                    //{
                    //    throw new Exception(string.Format("Index Out Of Range. i: {0}, NameLength: {1}, ZoneLength: {2}, LocationLength: {3}", 
                    //        i, mobNames.Length, zoneNames.Length, locationNames.Length));
                    //}
                }

                task.Mobs = mobs;

                return task;
            }));

            id = ctr;

            return tasks;
        }

        public HuntingLogTask[] Seed()
        {
            return GetSeeds(Seedlings, GetResource, Parse);
        }
    }
}
