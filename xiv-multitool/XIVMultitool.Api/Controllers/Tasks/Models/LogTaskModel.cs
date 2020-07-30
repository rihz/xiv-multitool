using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XIVChecklist.Api.Controllers.Tasks.Models
{
    public class SightseeingLogTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int PatchId { get; set; }
        public string PatchName { get; set; }
        public string Number { get; set; }
        public string Weather { get; set; }
        public string Time { get; set; }
        public string Emote { get; set; }
    }

    public class HuntingLogTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int HuntingLogTypeId { get; set; }
        public string HuntingLogTypeName { get; set; }
        public string Number { get; set; }
        public string Level { get; set; }
        public IEnumerable<HuntingLogMobModel> Mobs { get; set; }
    }

    public class HuntingLogMobModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Zone { get; set; }
        public string Location { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public int HuntingLogId { get; set; }
    }

    public class GatheringLogTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int GatherTypeId { get; set; }
        public string GatherTypeName { get; set; }
        public string Level { get; set; }
        public string Location { get; set; }
    }

    public class FishGuideTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int ILevel { get; set; }
        public int ZoneId { get; set; }
        public string ZoneName { get; set; }
        public string Bait { get; set; }
    }

    public class FishingLogTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public int iLevel { get; set; }
        public int ZoneId { get; set; }
        public string ZoneName { get; set; }
    }

    public class CraftingLogTaskModel : ITaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TaskTypeId { get; set; }
        public string Level { get; set; }
        public int CraftingLogTypeId { get; set; }
        public string CraftingLogTypeName { get; set; }
    }
}
