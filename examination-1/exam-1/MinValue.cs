using System;
using System.Linq;


namespace exam_1
{
    static class MinValue
    {
        public static int Minimum(int[] src)
        {
            ExceptionsHandler.exceptions(src);
            {
                return src.Min();
            }
        }
    }
}