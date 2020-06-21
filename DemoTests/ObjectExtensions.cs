using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoTests
{
    public static class ObjectExtensions
    {
        public static void Print<T>(this IEnumerable<T> source, string split = ",")
        {
            if (source == null || source.Any() == false)
            {
                Console.WriteLine("the source is empty");
            }
            Console.WriteLine(string.Join(split, source));
        }
    }
}
