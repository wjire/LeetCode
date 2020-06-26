/*
 * @lc app=leetcode.cn id=1071 lang=csharp
 *
 * [1071] 字符串的最大公因子
 *
 * https://leetcode-cn.com/problems/greatest-common-divisor-of-strings/description/
 *
 * algorithms
 * Easy (47.47%)
 * Likes:    146
 * Dislikes: 0
 * Total Accepted:    27K
 * Total Submissions: 46K
 * Testcase Example:  '"ABCABC"\n"ABC"'
 *
 * 对于字符串 S 和 T，只有在 S = T + ... + T（T 与自身连接 1 次或多次）时，我们才认定 “T 能除尽 S”。
 * 
 * 返回最长字符串 X，要求满足 X 能除尽 str1 且 X 能除尽 str2。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 输入：str1 = "ABCABC", str2 = "ABC"
 * 输出："ABC"
 * 
 * 
 * 示例 2：
 * 
 * 输入：str1 = "ABABAB", str2 = "ABAB"
 * 输出："AB"
 * 
 * 
 * 示例 3：
 * 
 * 输入：str1 = "LEET", str2 = "CODE"
 * 输出：""
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 1 <= str1.length <= 1000
 * 1 <= str2.length <= 1000
 * str1[i] 和 str2[i] 为大写英文字母
 * 
 * 
 */

// @lc code=start

using System;

public partial class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        //首先求长度的最大公约数
        int minLength = GCD(str1.Length, str2.Length);
        var s = str1.Substring(0, minLength);
        var count = (str1.Length + str2.Length) / minLength;
        var result = s;
        for (int i = 0; i < count - 1; i++)
        {
            result = result + s;
        }
        return result == (str1 + str2) ? s : string.Empty;
    }

    public string MyGcdOfStrings(string str1, string str2)
    {
        if (str1.Length == str2.Length)
        {
            return str1 == str2 ? str1 : string.Empty;
        }

        //首先求长度的最大公约数
        int minLength = GCD(str1.Length, str2.Length);

        var start = str1.Substring(0, minLength);
        if (start != str2.Substring(0, minLength))
        {
            return string.Empty;
        }

        var i = 0;
        while ((i += minLength) < str1.Length)
        {
            var r2 = str1.Substring(i, minLength);
            if (start != r2)
            {
                return string.Empty;
            }
        }

        i = 0;
        while ((i += minLength) < str2.Length)
        {
            var r2 = str2.Substring(i, minLength);
            if (start != r2)
            {
                return string.Empty;
            }
        }

        return str1.Substring(0, minLength);
    }

    private int GCD(int a, int b)
    {
        if (b == 0) return a;

        return GCD(b, a % b);
    }
}
// @lc code=end