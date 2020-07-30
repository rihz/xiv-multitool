using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Entities.Common
{
    public class Location : ICommon
    {
        public int Id { get; set; }

        public int ZoneId { get; set; }

        public string Name { get; set; }

        public virtual Zone Zone { get; set; }
    }
}
