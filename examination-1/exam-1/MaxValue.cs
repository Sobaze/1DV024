using System;
using System.Linq;


namespace exam_1
{
    static class MaxValue
    {
        public static int Maximum(int[] src) 
        {
            ExceptionsHandler.exceptions(src);
            {
                return src.Max();
            }
        }
    }
}