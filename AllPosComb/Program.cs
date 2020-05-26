using System;
using System.Collections.Generic;
using System.Linq;

namespace AllPosComb
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task:
            //    Implement the application which generates all possible combinations for a given array elements
            //  EXAMPLE:
            //      Array: ["a", "b", "c"]
            //      Result: [["a"], ["a","b"], ["a","b","c"], ["a","c"], ["a","c","b"], ["b"], ["b","a"], ["b","a","c"], ["b","c"], ["b","c","a"], ["c"], ["c","a"], ["c","a","b"], ["c","b"], ["c","b","a"]]

            var arr = new string[] { "a", "b", "c" };
            
            var tempDictionary = new Dictionary<string, string[]>();
            
            DoSearch(arr, tempDictionary);
            string[][] result = MapResultArray(tempDictionary);
            Console.WriteLine("Solution with loops");
            PrintResults(result);

            var result2 = GetPermutations(arr);
            Console.WriteLine("Solution with recursion");
            PrintResults(result2);
        }

        private static void PrintResults(IEnumerable<IEnumerable<string>> result)
        {
            foreach (var list in result)
            {
                Console.WriteLine(string.Join(",", list.Select(el => el)));
            }
        }

        private static string[][] MapResultArray(Dictionary<string, string[]> tempDictionary)
        {
            var tempList = new List<string[]>();
            foreach (var array in tempDictionary.Values)
            {
                tempList.Add(array.Where(item => !string.IsNullOrEmpty(item)).ToArray());
            }
            var result = tempList.ToArray();
            return result;
        }


        private static void DoSearch(string[] arr, Dictionary<string, string[]> tempDictionary)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        var tempJ = arr[j];
                        var tempK = arr[k];
                        if (arr[i] == arr[j])
                        {
                            tempJ = string.Empty;
                        }
                        if (arr[i] == arr[k])
                        {
                            tempK = string.Empty;
                        }
                        if (arr[j] == arr[k])
                        {
                            tempK = string.Empty;
                        }

                        var key = String.Concat(arr[i], tempJ, tempK);
                        if (!tempDictionary.ContainsKey(key))
                        {
                            tempDictionary.Add(key, new string[] { arr[i], tempJ, tempK });
                        }
                    }
                }
            }
        }


        // solution with recursion
        private static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                var itemAsEnumerable = Enumerable.Repeat(item, 1);
                var subSet = items.Except(itemAsEnumerable);
                if (!subSet.Any())
                {
                    yield return itemAsEnumerable;
                }
                else
                {
                    foreach (var sub in GetPermutations(items.Except(itemAsEnumerable)))
                    {
                        yield return itemAsEnumerable.Union(sub);
                    }
                }
            }
        }

    }
}
