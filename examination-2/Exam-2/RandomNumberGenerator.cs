using System;

namespace Exam_2
{
    class RandomeNumber
    {
        Random randomNum = new Random();

        public int RandomNumberGenerator(int min, int max)
        {
            return randomNum.Next(min, max);
        }
    }
}