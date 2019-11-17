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

public class Solution14
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }
        string res = string.Empty;
        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (i > strs[j].Length - 1)
                {
                    return res;
                }
                if (strs[0][i] != strs[j][i])
                {
                    return res;
                }
            }

            res += strs[0][i];
        }
        return res;
    }


    public string LongestCommonPrefix2(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }
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
        string res = string.Empty;
        for (int j = min.Length; j > 0; j--)
        {
            string s = min.Substring(0, j);
            bool flag = true;
            foreach (string pop in pops)
            {
                if (pop.StartsWith(s) == false)
                {
                    flag = false;
                    break;
                }
            }

            if (flag == true && s.Length > res.Length)
            {
                return s;
            }
        }
        return res;
    }
}
// @lc code=end

