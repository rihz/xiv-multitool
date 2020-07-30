using System;
using System.Collections.Generic;
using System.Text;

namespace XIVChecklist.Entities.Common
{
    public interface ICommon
    {
        int Id { get; set; }
        string Name { get; set; }
    }

    public class Common : ICommon
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
