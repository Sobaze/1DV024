using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace exam_1
{
    static class ModeValue
    {
        public static int[] Mode(int[] src)
        {
            ExceptionsHandler.exceptions(src);
            {
                int[] sortOrdernumbers = (int[])src.Clone();
                Array.Sort(sortOrdernumbers);
                var mode = sortOrdernumbers.GroupBy(i => i)
                .Select(i => new { Count = i.Count(), num = i.Key })
                .GroupBy(i => i.Count, i => i.num)
                .OrderByDescending(i => i.Key)
                .FirstOrDefault();
                
                return mode.ToArray();
            }
        }
    }
}