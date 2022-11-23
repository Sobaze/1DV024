using System;

namespace exam_1
{
    static class MeanValue
    {
        public static double Mean(int[] src)
        {
           ExceptionsHandler.exceptions(src);
            {
                double totalSum = 0;
                foreach ( int x in src)
                {
                    totalSum += x;
                }
                return totalSum / src.Length;
            }
        }
    }
}