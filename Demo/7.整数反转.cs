/*
 * @lc app=leetcode.cn id=7 lang=csharp
 *
 * [7] 整数反转
 */

// @lc code=start

using System;

public class Solution7
{
    public int Reverse(int x)
    {
        //123 => 321
        int res = 0;
        while (x != 0)
        {
            int pop = x % 10;
            if (res > Int32.MaxValue / 10 || (res == Int32.MaxValue / 10 && pop > 7))
            {
                return 0;
            }

            if (res < Int32.MinValue / 10 || (res == Int32.MinValue/10 && pop > 8))
            {
                return 0;
            }
            res = res * 10 + pop;
            x /= 10;
        }
        return res;
    }


    //该算法,使用了 long 类型,不符合题目要求
    //public int Reverse(int x)
    //{
    //    long res = 0;
    //    while (x != 0)
    //    {
    //        res = (x % 10) + (res * 10);
    //        if (res > Int32.MaxValue || res < Int32.MinValue) return 0;
    //        x /= 10;
    //    }
    //    return (int)res;
    //}



    //该算法不优雅
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

