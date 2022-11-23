using System;
using System.IO;

using Newtonsoft.Json;

namespace exam_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] number1 = { 4, 5, 7 } ;
            var json = File.ReadAllText("data.json");
            var numbers = JsonConvert.DeserializeObject<int[]>(json);


            dynamic stats = Statistics.DescriptiveStatistics(numbers);

            Console.WriteLine(stats);
        }
    }
}
