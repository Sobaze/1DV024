using System;
using System.Linq;

namespace exam_1
{
    static class StandardDeviationValue
    {
        public static double StandardDeviation(int[] src)
        {
            ExceptionsHandler.exceptions(src);
            {
                double avg = src.Average();

                double sum = src.Sum(d => (d - avg) * (d - avg));

                return Math.Sqrt(sum / src.Length);
            }
        }
    }
}