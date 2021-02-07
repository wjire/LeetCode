using System;
using System.Reflection;

namespace Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var logic = new Solution();
            var result = logic.CountAndSay(4);
            Console.WriteLine(result);
        }
    }
}
