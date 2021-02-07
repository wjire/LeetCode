/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *
 * [28] 实现 strStr()
 */

// @lc code=start
public partial class Solution
{
    /// <summary>
    /// 第一版
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrWhiteSpace(haystack) && string.IsNullOrWhiteSpace(needle))
        {
            return 0;
        }

        if (string.IsNullOrWhiteSpace(haystack))
        {
            return -1;
        }

        if (string.IsNullOrWhiteSpace(needle))
        {
            return 0;
        }

        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        if (haystack.Length == needle.Length)
        {
            for (int index = 0; index < haystack.Length; index++)
            {
                if (haystack[index] != needle[index]) return -1;
            }
            return 0;
        }

        var needleStart = 0;
        int i;
        for (i = 0; i < haystack.Length; i++)
        {
            if (needleStart == needle.Length)
            {
                return i -= needle.Length;
            }
            if (haystack[i] != needle[needleStart])
            {
                i -= needleStart;
                needleStart = 0;
            }
            else
            {
                needleStart++;
            }
        }

        if (needleStart == needle.Length)
        {
            return i -= needle.Length;
        }

        return -1;
    }

    /// <summary>
    /// 第一版
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public int StrStr2(string haystack, string needle)
    {
        if (string.IsNullOrWhiteSpace(haystack) && string.IsNullOrWhiteSpace(needle))
        {
            return 0;
        }

        if (string.IsNullOrWhiteSpace(haystack))
        {
            return -1;
        }

        if (string.IsNullOrWhiteSpace(needle))
        {
            return 0;
        }

        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        if (haystack.Length == needle.Length)
        {
            for (int index = 0; index < haystack.Length; index++)
            {
                if (haystack[index] != needle[index]) return -1;
            }
            return 0;
        }

        var needleStart = 0;
        int i;
        for (i = 0; i < haystack.Length; i++)
        {
            if (needleStart == needle.Length)
            {
                return i -= needle.Length;
            }
            if (haystack[i] != needle[needleStart])
            {
                i -= needleStart;
                needleStart = 0;
            }
            else
            {
                needleStart++;
            }
        }

        if (needleStart == needle.Length)
        {
            return i -= needle.Length;
        }

        return -1;
    }
}
// @lc code=end

