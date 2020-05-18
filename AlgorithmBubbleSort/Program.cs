using System;

namespace AlgorithmBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            Console.WriteLine(string.Join(",", arr));
            Console.WriteLine(string.Join(",", Sort(arr)));
        }

        // https://en.wikipedia.org/wiki/Bubble_sort#/media/File:Bubble-sort-example-300px.gif
        static int[] Sort(int[] arr)
        {
            int temp = 0;

            for (int mainLoop = 0; mainLoop < arr.Length; mainLoop++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
