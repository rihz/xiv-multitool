using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XIVChecklist.Data.Extensions
{
    public static class StringExtensions
    {
        public static string[] TrimSplit(this string str, params char[] toSplit)
        {
            return str.Split(toSplit)
                .Select(x => x.Trim())
                .ToArray();
        }
    }
}
