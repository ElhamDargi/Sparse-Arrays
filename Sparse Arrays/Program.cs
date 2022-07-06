using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparse_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> {"ab", "ab", "abc" };
            List<string> queries = new List<string> {"ab","abc","bc"};
            List<int> results = new List<int>();
            foreach (var item in queries)
            {
                results.Add(strings.Count(x => x == item));
            }
            results.ForEach(Console.WriteLine);
        }
    }
}
