/*
 * @lc app=leetcode.cn id=67 lang=csharp
 *
 * [67] 二进制求和
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    //"1010", "1011"
    public string AddBinary(string a, string b)
    {
        var la = a.Length;
        var lb = b.Length;
        if (lb > la)
        {
            (a, b) = (b, a);
            for (int i = 1; i <= lb - la; i++)
            {
                b = '0' + b;
            }
        }
        else if (la > lb)
        {
            for (int i = 1; i <= la - lb; i++)
            {
                b = '0' + b;
            }
        }

        var result = string.Empty;
        var temp = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            var itemA = ConvertChar(a[i]);
            var itemB = ConvertChar(b[i]);
            var sum = itemA + itemB + temp;
            switch (sum)
            {
                case 0:
                    result = '0' + result;
                    temp = 0;
                    break;
                case 1:
                    result = '1' + result;
                    temp = 0;
                    break;
                case 2:
                    result = '0' + result;
                    temp = 1;
                    break;
                case 3:
                    result = '1' + result;
                    temp = 1;
                    break;
            }
        }
        if (temp > 0)
        {
            result = '1' + result;
        }

        return result;
    }

    //"1010", "1011"
    public string AddBinary2(string a, string b)
    {
        var aStack = new Stack<char>(a);
        var bStack = new Stack<char>(b);
        var stack = new Stack<char>();
        var temp = 0;
        while (aStack.Count > 0 || bStack.Count > 0)
        {
            var itemA = 0;
            var itemB = 0;
            if (aStack.Count > 0)
            {
                itemA = ConvertChar(aStack.Pop());
            }

            if (bStack.Count > 0)
            {
                itemB = ConvertChar(bStack.Pop());
            }

            var sum = itemA + itemB + temp;
            switch (sum)
            {
                case 0:
                    stack.Push('0');
                    temp = 0;
                    break;
                case 1:
                    stack.Push('1');
                    temp = 0;
                    break;
                case 2:
                    stack.Push('0');
                    temp = 1;
                    break;
                case 3:
                    stack.Push('1');
                    temp = 1;
                    break;
            }
        }

        if (temp > 0)
        {
            stack.Push('1');
        }

        var sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }

        return sb.ToString();
    }

    private int ConvertChar(char c)
    {
        switch (c)
        {
            case '1':
                return 1;
            default:
                return 0;
        }
    }
}
// @lc code=end