using System;
using System.Linq;

namespace exam_1
{
    static class RangeValue
    {
        public static int Range(int[] src)
        {
            ExceptionsHandler.exceptions(src);
            {
                return src.Max() - src.Min();
            }
        }
    }
}