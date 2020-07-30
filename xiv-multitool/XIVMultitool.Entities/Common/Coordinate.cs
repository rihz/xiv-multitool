using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Entities.Common
{
    public class Coordinate
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }

        public Coordinate() { }

        public Coordinate(string x, string y)
        {
            try
            {
                X = decimal.Parse(x.Trim());
                Y = decimal.Parse(y.Trim());
            }
            catch(Exception ex)
            {
                var l = 'l';
            }
        }
    }
}
