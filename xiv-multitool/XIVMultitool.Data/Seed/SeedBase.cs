using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using XIVChecklist.Data.Seed.Seedlings;
using XIVChecklist.Entities.Common;
using XIVChecklist.Entities.Tasks;

namespace XIVChecklist.Data.Seed
{
    public interface ISeed<T> where T : ITask
    {
        Seedling[] Seedlings { get; }

        Stream GetResource(string name);

        IEnumerable<T> Parse(Stream resource, Seedling seedling, ref int id);

        T[] Seed();
    }

    public abstract class Seed<T> : IDisposable where T : ITask
    {
        const string NAMESPACE = "XIVChecklist.Data.SeedFiles.";
        const string RESOURCE = "{0} - {1}.csv";

        public Stream _stream { get; set; }

        static Assembly Assembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        public delegate IEnumerable<T> ParseTasks(Stream resource, Seedling seedling, ref int id);

        public T[] GetSeeds(Seedling[] seedlings, Func<string, Stream> GetResource, ParseTasks ParseTasks)
        {
            var tasks = new List<T>();
            var id = 0;

            foreach (var seed in seedlings)
            {
                _stream = GetResource(seed.FileName);

                tasks.AddRange(ParseTasks(_stream, seed, ref id));
            }
            var grouped = tasks.GroupBy(x => x.Id).Where(a => a.Count() > 1).ToList();
            return tasks.ToArray();
        }

        public Stream GetResourceStream(string primary, string secondary)
        {
            return GetResourceStream(string.Format(RESOURCE, primary, secondary));
        }

        public List<TT> ParseResource<TT>(Stream resource) where TT : class
        {
            var parse = new List<TT>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HeaderValidated = null;
            config.MissingFieldFound = null;

            using (var reader = new StreamReader(resource))
            using (var csv = new CsvReader(reader, config))
            {
                parse = csv.GetRecords<TT>()
                    .ToList();
            }

            return parse;
        }

        public LocationSplit SplitLocation(string location)
        {
            try
            {
                var split = location.Split('(');

                var name = split[0].Trim();
                var coords = split[1].Split(',', ')');

                return new LocationSplit
                {
                    Name = name,
                    Coordinates = new Coordinate(coords[0], coords[1])
                };
            }
            catch (Exception)
            {
                return new LocationSplit
                {
                    Name = location,
                    Coordinates = null
                };
            }
        }

        Stream GetResourceStream(string name)
        {
            return Assembly.GetManifestResourceStream(NAMESPACE + name);
        }

        public void Dispose()
        {
            if (_stream != null)
            {
                _stream.Dispose();
            }
        }
    }

    public class LocationSplit
    {
        public string Name { get; set; }

        public Coordinate Coordinates { get; set; }
    }
}
