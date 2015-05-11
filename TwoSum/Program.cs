using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            if (list == null || list.Count < 2)
                return null;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                int diff = sum - list[i];
                if (dict.ContainsKey(diff))
                    return new Tuple<int, int>(i, dict[diff]);

                if (!dict.ContainsKey(list[i]))
                    dict[list[i]] = i;
            }

            return null;
        }

        public static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 10, 12, 0, 1,1,3,3, 5, 7, 9 }, 11);
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
            Console.Read();
        }
    }
}
