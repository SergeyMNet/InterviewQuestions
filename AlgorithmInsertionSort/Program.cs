using System;

namespace AlgorithmInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            Console.WriteLine(string.Join(",", arr));
            Console.WriteLine(string.Join(",", InsertionSort(arr)));
        }

        // https://www.w3resource.com/w3r_images/Insertion-sort-animation.gif
        public static int[] InsertionSort(int[] arr)
        {
            int temp, j;

            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }

            return arr;
        }
    }
}
