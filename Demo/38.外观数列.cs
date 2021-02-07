/*
 * @lc app=leetcode.cn id=38 lang=csharp
 *
 * [38] 外观数列
 */

// @lc code=start

using System.Text;

public partial class Solution
{
    //4,1211
    public string CountAndSay(int n)
    {
        var result = "1";
        if (n == 1)
        {
            return result;
        }
        for (int i = 2; i <= n; i++)
        {
            result = Count(result);
        }
        return result;
    }

    public string Count(string s)
    {
        //设置哨兵: 避免循环完后,还要再统计一次
        s += "e";
        var result = new StringBuilder(16);
        var start = s[0];
        var count = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == start)
            {
                count++;
                continue;
            }

            result.Append(count.ToString());
            result.Append(start);
            start = s[i];
            count = 1;
        }
        return result.ToString();
    }
}
// @lc code=end

