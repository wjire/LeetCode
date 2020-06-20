/*
 * @lc app=leetcode.cn id=350 lang=csharp
 *
 * [350] 两个数组的交集 II
 *
 * https://leetcode-cn.com/problems/intersection-of-two-arrays-ii/description/
 *
 * algorithms
 * Easy (44.82%)
 * Likes:    285
 * Dislikes: 0
 * Total Accepted:    91.2K
 * Total Submissions: 187.2K
 * Testcase Example:  '[1,2,2,1]\n[2,2]'
 *
 * 给定两个数组，编写一个函数来计算它们的交集。
 * 
 * 示例 1:
 * 
 * 输入: nums1 = [1,2,2,1], nums2 = [2,2]
 * 输出: [2,2]
 * 
 * 
 * 示例 2:
 * 
 * 输入: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
 * 输出: [4,9]
 * 
 * 说明：
 * 
 * 
 * 输出结果中每个元素出现的次数，应与元素在两个数组中出现的次数一致。
 * 我们可以不考虑输出结果的顺序。
 * 
 * 
 * 进阶:
 * 
 * 
 * 如果给定的数组已经排好序呢？你将如何优化你的算法？
 * 如果 nums1 的大小比 nums2 小很多，哪种方法更优？
 * 如果 nums2 的元素存储在磁盘上，磁盘内存是有限的，并且你不能一次加载所有的元素到内存中，你该怎么办？
 * 
 * 
 */

// @lc code=start

using System.Collections.Generic;

public partial class Solution
{

    public int[] Intersect(int[] nums1, int[] nums2)
    {
        //nums1 = [4,4,9,5], nums2 = [9,4,9,8,4]
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (dic.ContainsKey(nums1[i]))
            {
                dic[nums1[i]]++;
                continue;
            }

            dic.Add(nums1[i], 1);
        }

        var result = new List<int>();

        for (int i = 0; i < nums2.Length; i++)
        {
            if (dic.ContainsKey(nums2[i]))
            {
                if (dic[nums2[i]] > 0)
                {
                    result.Add(nums2[i]);
                    dic[nums2[i]]--;
                }
                else
                {
                    dic.Remove(nums2[i]);
                }
            }
        }

        return result.ToArray();
    }

    public int[] MyIntersect(int[] nums1, int[] nums2)
    {
        //nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        var set = new HashSet<int>();
        var result = new List<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (set.Contains(j))
                {
                    continue;
                }

                if (nums2[j] != nums1[i])
                {
                    continue;
                }
                set.Add(j);
                result.Add(nums2[j]);
                break;
            }
        }

        return result.ToArray();
    }
}
// @lc code=end