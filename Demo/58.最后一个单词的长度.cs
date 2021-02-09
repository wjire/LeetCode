/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public partial class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        var length = s.Length;
        var start = 0;
        var end = length - 1;
        var empty = ' ';
        var resultIndex = -1;
        while (start <= end)
        {
            if (s[end] == empty)
            {
                return length - end - 1;
            }
            if (s[start] == empty)
            {
                resultIndex = start;
            }
            start++;
            end--;
        }

        if (resultIndex != -1)
        {
            return length - resultIndex - 1;
        }
        return length;
    }
}
// @lc code=end

