/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 *
 * https://leetcode-cn.com/problems/plus-one/description/
 *
 * algorithms
 * Easy (41.60%)
 * Likes:    487
 * Dislikes: 0
 * Total Accepted:    165.6K
 * Total Submissions: 372.9K
 * Testcase Example:  '[1,2,3]'
 *
 * 给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
 * 
 * 最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。
 * 
 * 你可以假设除了整数 0 之外，这个整数不会以零开头。
 * 
 * 示例 1:
 * 
 * 输入: [1,2,3]
 * 输出: [1,2,4]
 * 解释: 输入数组表示数字 123。
 * 
 * 
 * 示例 2:
 * 
 * 输入: [4,3,2,1]
 * 输出: [4,3,2,2]
 * 解释: 输入数组表示数字 4321。
 * 
 * 
 */

// @lc code=start
public partial class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }     
        var result = new int[digits.Length + 1];
        result[0] = 1;   
        return result;
    }

    public int[] MyPlusOne(int[] digits)
    {
        var s = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            var d = digits[i];
            digits[i] = (d + s) % 10;
            s = (d + s) / 10;
        }

        if (digits[0] != 0)
        {
            return digits;
        }
        var result = new int[digits.Length + 1];
        result[0] = 1;
        for (int i = 1; i < result.Length; i++)
        {
            result[i] = digits[i - 1];
        }
        return result;
    }
}
// @lc code=end