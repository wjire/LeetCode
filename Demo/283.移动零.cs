/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 *
 * https://leetcode-cn.com/problems/move-zeroes/description/
 *
 * algorithms
 * Easy (57.43%)
 * Likes:    617
 * Dislikes: 0
 * Total Accepted:    161.4K
 * Total Submissions: 263.6K
 * Testcase Example:  '[0,1,0,3,12]'
 *
 * 给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
 * 
 * 示例:
 * 
 * 输入: [0,1,0,3,12]
 * 输出: [1,3,12,0,0]
 * 
 * 说明:
 * 
 * 
 * 必须在原数组上操作，不能拷贝额外的数组。
 * 尽量减少操作次数。
 * 
 * 
 */

// @lc code=start
public partial class Solution
{
    public void MoveZeroes(int[] nums)
    {
        // 0,1,0,3,12
        int len = nums.Length;
        int num = 0;
        int zero = 1;
        while (zero < len)
        {
            if (nums[num] != 0)
            {
                num++;
                zero = num + 1;
            }
            else if (nums[zero] == 0)
            {
                zero++;
            }
            else
            {
                (nums[zero], nums[num]) = (nums[num], nums[zero]);
                num++;
                zero++;
            }
        }
    }

    public void MyMoveZeroes2(int[] nums)
    {
        // 0,1,0,3,12
        var j = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (i >= j)
                {
                    j = i + 1;
                }
                continue;
            }

            if (j == nums.Length - 1)
            {
                return;
            }
            nums[i] = nums[j + 1];
            nums[j + 1] = 0;
            i--;
            j++;
        }
    }


    public void MyMoveZeroes1(int[] nums)
    {
        var j = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[j] = nums[i];
                j++;
            }
        }

        for (int i = j; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
// @lc code=end