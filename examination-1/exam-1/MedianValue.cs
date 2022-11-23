using System;
using System.Linq;

namespace exam_1
{
    static class MedianValue
    {
        public static double Median(int[] src)
        {
            ExceptionsHandler.exceptions(src);
            {
                int[] sortOrdernumbers = (int[])src.Clone();
                Array.Sort(sortOrdernumbers);
                double medianNumber = 0;
                int midNumber = sortOrdernumbers.Length / 2;
                if (sortOrdernumbers.Length % 2 == 0)
                {
                    medianNumber = ((int)sortOrdernumbers[midNumber- 1] + (int)sortOrdernumbers[midNumber]) / 2;
                }
                else
                {
                    medianNumber = (int)sortOrdernumbers[midNumber];
                }
                
                return medianNumber;
            }
        }
    }
}