using System;

namespace Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var strs =new string[]{"flower", "flow", "flight"};
            var strs =new string[]{"ca", "a"};
            Console.WriteLine(new Solution().LongestCommonPrefix(strs));

            Console.ReadKey();
        }
    }
}
