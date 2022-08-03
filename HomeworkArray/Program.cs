using System;

namespace HomeworkArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 24, 16, 19, 23, 28, 34, 39, 124, 128, 234,2, 256, 643 };
            int min=array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min>array[i])
                {
                    min = array[i];

                }

            }
            Console.WriteLine(min);
        }
    }
}
