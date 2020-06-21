using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DemoTests;

namespace Tests
{
    [TestClass()]
    public class SolutionTests
    {
        private Solution sln = new Solution();

        [TestMethod()]
        public void RemoveElementTest()
        {
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var val = 2;
            var result = new Solution().RemoveElement(nums, val);
            Console.WriteLine(result);
            Console.WriteLine(string.Join(",", nums));
        }

        [TestMethod()]
        public void SearchInsertTest()
        {
            var nums = new int[] { 1, 3 };
            var val = 2;
            var result = new Solution().SearchInsert(nums, val);
            Console.WriteLine(result);
        }

        [TestMethod()]
        public void IntersectTest()
        {
            var nums1 = new int[] { 4, 9, 4, 5 };
            var nums2 = new int[] { 9, 4, 9, 8, 4 };
            var result = new Solution().Intersect(nums1, nums2);
            Console.WriteLine(string.Join(",", result));
        }

        [TestMethod()]
        public void MoveZeroesTest()
        {
            var nums = new int[] { 0, 1, 0, 3, 12 };
            sln.MoveZeroes(nums);
            Console.WriteLine(string.Join(",", nums));
        }

        [TestMethod()]
        public void FlipAndInvertImageTest()
        {
            // [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
            var arr = new int[][]
            {
                new int[] {1, 1, 0, 0},
                new int[] {1, 0, 0, 1},
                new int[] {0, 1, 1, 1},
                new int[] {1, 0, 1, 0},
            };
            var result = sln.FlipAndInvertImage(arr);
            foreach (var i in result)
            {
                i.Print();
            }
        }
    }
}