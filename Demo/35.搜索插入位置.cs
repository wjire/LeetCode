/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 *
 * https://leetcode-cn.com/problems/search-insert-position/description/
 *
 * algorithms
 * Easy (44.54%)
 * Likes:    540
 * Dislikes: 0
 * Total Accepted:    170.3K
 * Total Submissions: 372.8K
 * Testcase Example:  '[1,3,5,6]\n5'
 *
 * 给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
 * 
 * 你可以假设数组中无重复元素。
 * 
 * 示例 1:
 * 
 * 输入: [1,3,5,6], 5
 * 输出: 2
 * 
 * 
 * 示例 2:
 * 
 * 输入: [1,3,5,6], 2
 * 输出: 1
 * 
 * 
 * 示例 3:
 * 
 * 输入: [1,3,5,6], 7
 * 输出: 4
 * 
 * 
 * 示例 4:
 * 
 * 输入: [1,3,5,6], 0
 * 输出: 0
 * 
 * 
 */

// @lc code=start

public partial class Solution
{
    //二分
    public int SearchInsert(int[] nums, int target)
    {

        var s = 0;
        var e = nums.Length - 1;
        var mid = s;
        while (s <= e)
        {
            mid = s + (e - s) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] > target)
            {
                e = mid - 1;
            }
            else if (nums[mid] < target)
            {
                s = mid + 1;
            }
        }
        return s;
    }

    //二分
    public int MySearchInsert2(int[] nums, int target)
    {

        var s = 0;
        var e = nums.Length - 1;
        var mid = 0;
        while (s <= e)
        {
            mid = (s + e) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] > target)
            {
                e = mid - 1;
            }
            else if (nums[mid] < target)
            {
                s = mid + 1;
            }
        }
        if (target > nums[mid])
        {
            return mid + 1;
        }
        return mid;
    }

    public int MySearchInsert1(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
            {
                return i;
            }
        }
        return nums.Length;
    }
}

// @lc code=end