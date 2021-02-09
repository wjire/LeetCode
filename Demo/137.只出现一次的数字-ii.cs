/*
 * @lc app=leetcode.cn id=137 lang=csharp
 *
 * [137] 只出现一次的数字 II
 */

// @lc code=start
public partial class Solution
{
    public int SingleNumber(int[] nums)
    {
        var arr = new int[int.MaxValue];
        for (int i = 0; i < nums.Length; i++)
        {
            arr[nums[i]]++;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}
// @lc code=end

