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
            PrintResults(result);
        }

        private static void PrintResults(string[][] result)
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
                            tempJ = "";
                        }
                        if (arr[i] == arr[k])
                        {
                            tempK = "";
                        }
                        if (arr[j] == arr[k])
                        {
                            tempK = "";
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
    }
}
