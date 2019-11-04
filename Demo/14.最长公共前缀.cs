/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 *
 * https://leetcode-cn.com/problems/longest-common-prefix/description/
 *
 * algorithms
 * Easy (35.14%)
 * Likes:    752
 * Dislikes: 0
 * Total Accepted:    142.5K
 * Total Submissions: 405K
 * Testcase Example:  '["flower","flow","flight"]'
 *
 * 编写一个函数来查找字符串数组中的最长公共前缀。
 * 
 * 如果不存在公共前缀，返回空字符串 ""。
 * 
 * 示例 1:
 * 
 * 输入: ["flower","flow","flight"]
 * 输出: "fl"
 * 
 * 
 * 示例 2:
 * 
 * 输入: ["dog","racecar","car"]
 * 输出: ""
 * 解释: 输入不存在公共前缀。
 * 
 * 
 * 说明:
 * 
 * 所有输入只包含小写字母 a-z 。
 * 
 */

// @lc code=start

using System.Linq;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }
        string min = strs.First(f => f.Length == strs.Min(m => m.Length));
        System.Collections.Generic.List<string> pops = strs.Except(new string[] { min }).ToList();
        if (pops.Count == 0)
        {
            return min;
        }

        int l = 0;
        string res = string.Empty;
        for (int i = 0; i < min.Length; i++)
        {
            for (int j = 1; j <= min.Length; j++)
            {
                string s = min.Substring(i, j);
                if (pops.Exists(e => e != s))
                {
                    break;
                }
                else
                {
                    if (s.Length > l)
                    {
                        l = s.Length;
                        res = s;
                    }
                }
            }
        }
        return res;
    }
}
// @lc code=end

