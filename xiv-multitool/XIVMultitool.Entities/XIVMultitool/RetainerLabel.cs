using System;
using System.Collections.Generic;
using System.Text;

namespace XIVMultitool.Entities.XIVMultitool
{
    public class RetainerLabel
    {
        public int Id { get; set; }
        public int RetainerId { get; set; }
        public string Name { get; set; }
        public string ColorHex { get; set; }

        public virtual Retainer Retainer { get; set; }
    }
}
