/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */

// @lc code=start

using System.Collections.Generic;

public class Solution13
{
    public int RomanToInt(string s)
    {
        var result = 0;
        if (string.IsNullOrWhiteSpace(s))
        {
            return result;
        }

        var dic = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1)
            {
                result += dic[s[i]];
            }
            else if (dic[s[i]] < dic[s[i + 1]])
            {
                result -= dic[s[i]];
            }
            else
            {
                result += dic[s[i]];
            }
        }

        return result;
    }


    //自己的SB解法
    public int RomanToInt2(string s)
    {
        var result = 0;
        if (string.IsNullOrWhiteSpace(s))
        {
            return result;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I')
            {
                if (i == s.Length - 1)
                {
                    result += 1;
                }
                else if (s[i + 1] == 'V')
                {
                    result += 4;
                    i++;
                }
                else if (s[i + 1] == 'X')
                {
                    result += 9;
                    i++;
                }
                else
                {
                    result += 1;
                }
            }
            else if (s[i] == 'X')
            {
                if (i == s.Length - 1)
                {
                    result += 10;
                }
                else if (s[i + 1] == 'L')
                {
                    result += 40; i++;
                }
                else if (s[i + 1] == 'C')
                {
                    result += 90; i++;
                }
                else
                {
                    result += 10;
                }
            }
            else if (s[i] == 'C')
            {
                if (i == s.Length - 1)
                {
                    result += 100;
                }
                else if (s[i + 1] == 'D')
                {
                    result += 400; i++;
                }
                else if (s[i + 1] == 'M')
                {
                    result += 900; i++;
                }
                else
                {
                    result += 100;
                }
            }
            else if (s[i] == 'V')
            {
                result += 5;
            }
            else if (s[i] == 'L')
            {
                result += 50;
            }
            else if (s[i] == 'D')
            {
                result += 500;
            }
            else if (s[i] == 'M')
            {
                result += 1000;
            }
        }

        return result;
    }
}
// @lc code=end

