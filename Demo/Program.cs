using System;
using System.Reflection;

namespace Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = new[] { 2, 2, 3, 2 };
            var logic = new Solution();
            var result = logic.SingleNumber(input);
            Console.WriteLine(result);
        }
    }
}
