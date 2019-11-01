/*
 * @lc app=leetcode.cn id=7 lang=csharp
 *
 * [7] 整数反转
 */

// @lc code=start

using System;

public class Solution
{
    public int Reverse(int x)
    {
        long res = 0;
        while (x != 0)
        {
            res = (x % 10) + (res * 10);
            if (res > Int32.MaxValue || res < Int32.MinValue) return 0;
            x /= 10;
        }
        return (int)res;
    }

    //public int Reverse(int x)
    //{
    //    int m = 1;
    //    string s = x.ToString();
    //    if (x < 0)
    //    {
    //        m = -1;
    //        s = s.Substring(1);
    //    }
    //    long result = 0;
    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        result = result + Convert.ToInt32(s[i].ToString()) * (long)Math.Pow(10, i);
    //    }
    //    result = result * m;
    //    if (result < int.MinValue || result > int.MaxValue)
    //    {
    //        return 0;
    //    }
    //    return Convert.ToInt32(result);
    //}
}
// @lc code=end

