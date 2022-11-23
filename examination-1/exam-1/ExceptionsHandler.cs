using System;

namespace exam_1
{
    static class ExceptionsHandler
    {
        public static void exceptions (int [] src)
        {
            if ( src == null)
            {
                throw new ArgumentNullException();
            }
            else if (src.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
        }
    }
}