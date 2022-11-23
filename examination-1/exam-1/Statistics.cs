using System;


namespace exam_1
{
    static class Statistics
    {
        public static dynamic DescriptiveStatistics(int[] source)
        {
            int max = MaxValue.Maximum(source);
            double mean = MeanValue.Mean(source);
            double median = MedianValue.Median(source);
            int min = MinValue.Minimum(source);
            int[] mode = ModeValue.Mode(source);
            int range = RangeValue.Range(source);
            double standardDeviation = StandardDeviationValue.StandardDeviation(source);

            var stringTheMode = string.Join(",", mode);

            return $"Maxmimum: {max}\n" + $"Minimum: {min}\n" + $"Medelvärde: {mean:f1}\n" + $"Median: {median}\n"
            + $"Typvärde: {stringTheMode}\n" + $"Variationsbredd: {range}\n" + $"Standardavvikelse: {standardDeviation:f1}";
        }
    }
}