/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 *
 * https://leetcode-cn.com/problems/maximum-subarray/description/
 *
 * algorithms
 * Easy (47.88%)
 * Likes:    2102
 * Dislikes: 0
 * Total Accepted:    263.6K
 * Total Submissions: 512.1K
 * Testcase Example:  '[-2,1,-3,4,-1,2,1,-5,4]'
 *
 * 给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
 * 
 * 示例:
 * 
 * 输入: [-2,1,-3,4,-1,2,1,-5,4],
 * 输出: 6
 * 解释: 连续子数组 [4,-1,2,1] 的和最大，为 6。
 * 
 * 
 * 进阶:
 * 
 * 如果你已经实现复杂度为 O(n) 的解法，尝试使用更为精妙的分治法求解。
 * 
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    //[-2,1,-3,4,-1,2,1,-5,4]
    public int MaxSubArray(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }

        var temp = nums[0];
        var preCount = temp;
        var result = temp;
        for (int i = 1; i < nums.Length; i++)
        {
            var num = nums[i];
            var count = temp + num;
            if (count >= temp)
            {
                temp = count;
                continue;
            }

            if (result < count)
            {
                result = count;
                continue;
            }
            else
            {
                result = temp;
            }
            temp = nums[i];
        }

        return result;
    }
}
// @lc code=end

