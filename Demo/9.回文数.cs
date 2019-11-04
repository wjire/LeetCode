/*
 * @lc app=leetcode.cn id=9 lang=csharp
 *
 * [9] 回文数
 *
 * https://leetcode-cn.com/problems/palindrome-number/description/
 *
 * algorithms
 * Easy (56.67%)
 * Likes:    800
 * Dislikes: 0
 * Total Accepted:    190.5K
 * Total Submissions: 336.2K
 * Testcase Example:  '121'
 *
 * 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
 * 
 * 示例 1:
 * 
 * 输入: 121
 * 输出: true
 * 
 * 
 * 示例 2:
 * 
 * 输入: -121
 * 输出: false
 * 解释: 从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
 * 
 * 
 * 示例 3:
 * 
 * 输入: 10
 * 输出: false
 * 解释: 从右向左读, 为 01 。因此它不是一个回文数。
 * 
 * 
 * 进阶:
 * 
 * 你能不将整数转为字符串来解决这个问题吗？
 * 
 */

// @lc code=start


using System;

public class Solution9
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int length = 1;
        int temp = x;
        while (temp > 9)
        {
            length++;
            temp = temp / 10;
        }

        while (length > 1)
        {
            int t = (int)Math.Pow(10, (length - 1));
            int left = x / t;
            int right = x % 10;
            if (left != right)
            {
                return false;
            }

            x = (x - left * t) / 10;
            length -= 2;
        }
        return true;
    }
}
// @lc code=end

