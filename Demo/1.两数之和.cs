/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 *
 * https://leetcode-cn.com/problems/two-sum/description/
 *
 * algorithms
 * Easy (46.93%)
 * Likes:    6727
 * Dislikes: 0
 * Total Accepted:    648.9K
 * Total Submissions: 1.4M
 * Testcase Example:  '[2,7,11,15]\n9'
 *
 * 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
 * 
 * 你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
 * 
 * 示例:
 * 
 * 给定 nums = [2, 7, 11, 15], target = 9
 * 
 * 因为 nums[0] + nums[1] = 2 + 7 = 9
 * 所以返回 [0, 1]
 * 
 * 
 */

// @lc code=start

using System.Collections.Generic;

public partial class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var d = target - nums[i];
            if (dic.ContainsKey(d))
            {
                return new int[] { dic[d], i };
            }

            if (dic.ContainsKey(nums[i]) == false)
            {
                dic.Add(nums[i], i);
            }
        }
        return null;
    }


    public int[] MyTwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }
        return null;
    }
}
// @lc code=end

