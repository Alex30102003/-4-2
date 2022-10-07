using System;
using System.Diagnostics;

namespace ConsoleApplication
{
    internal static class Program
    {
        private static void Main()
        {
            var array = new int[6000];

            var random = new Random();
            for (var i = 0; i < array.Length; i++)
                array[i] = random.Next(int.MaxValue);

            Console.WriteLine("Sorting...");
            var stopWatch = Stopwatch.StartNew();
            Sort(array);
            stopWatch.Stop();

            Check(array);
            Console.WriteLine("Time: {0} ms", stopWatch.ElapsedMilliseconds);
        }

        private static void Sort(int[] array)
        {
            bool flag;
            do
            {
                flag = false;
                for (var i = 0; i < array.Length - 1; i++)
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        flag = true;
                    }
            }
            while (flag);
        }

        private static void Check(int[] array)
        {
            var check = true;
            for (var i = 0; i < array.Length - 1; i++)
                if (array[i] > array[i + 1])
                {
                    check = false;
                    break;
                }
            Console.WriteLine("Check array: {0}", check);
        }
    }
}