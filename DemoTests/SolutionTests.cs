using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Demo.Model;

namespace DemoTests
{
    [TestClass]
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

        [TestMethod()]
        public void HeightCheckerTest()
        {
            var arr = new int[] { 1, 1, 4, 2, 1, 3 };
            var result = sln.HeightChecker(arr);
        }

        [TestMethod()]
        public void GcdOfStringsTest()
        {
            var str1 = "ABCABC";
            var str2 = "ABC";
            var result = sln.GcdOfStrings(str1, str2);
            Console.WriteLine(result);
        }

        [TestMethod()]
        public void RemoveElementsTest()
        {
            //1->2->6->3->4->5->6
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)
                                {
                                    next = new ListNode(6)
                                }
                            }
                        }
                    }
                }
            };
            var result = sln.RemoveElements(head, 6);
            while (result != null)
            {
                Console.Write(result.val + ",");
                result = result.next;
            }
        }

        [TestMethod]
        public void CombinationSumTest()
        {
            var nums = new int[] {2, 3, 5};
            var target = 8;
            var result = sln.CombinationSum(nums, target);
            Console.WriteLine(string.Join(",",result));
        }
    }
}