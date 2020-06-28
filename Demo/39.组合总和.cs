/*
 * @lc app=leetcode.cn id=39 lang=csharp
 *
 * [39] 组合总和
 *
 * https://leetcode-cn.com/problems/combination-sum/description/
 *
 * algorithms
 * Medium (69.03%)
 * Likes:    738
 * Dislikes: 0
 * Total Accepted:    104.4K
 * Total Submissions: 151.3K
 * Testcase Example:  '[2,3,6,7]\n7'
 *
 * 给定一个无重复元素的数组 candidates 和一个目标数 target ，找出 candidates 中所有可以使数字和为 target 的组合。
 * 
 * candidates 中的数字可以无限制重复被选取。
 * 
 * 说明：
 * 
 * 
 * 所有数字（包括 target）都是正整数。
 * 解集不能包含重复的组合。 
 * 
 * 
 * 示例 1:
 * 
 * 输入: candidates = [2,3,6,7], target = 7,
 * 所求解集为:
 * [
 * ⁠ [7],
 * ⁠ [2,2,3]
 * ]
 * 
 * 
 * 示例 2:
 * 
 * 输入: candidates = [2,3,5], target = 8,
 * 所求解集为:
 * [
 * [2,2,2,2],
 * [2,3,3],
 * [3,5]
 * ]
 * 
 */

// @lc code=start

using System;
using System.Collections.Generic;

public partial class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var result = new List<IList<int>>();
        for (int i = 0; i < candidates.Length; i++)
        {
            if (candidates[i] > target)
            {
                return result;
            }

            var c = target % candidates[i];
            if (c == 0)
            {
                var temp = new List<int>();
                for (int j = 0; j < target / candidates[i]; j++)
                {
                    temp.Add(candidates[i]);
                }
                result.Add(temp);
            }
            else
            {
                for (int j = 1; j <= target / candidates[i]; j++)
                {
                    var t = candidates[i] * j + c;
                    for (int k = 0; k < candidates.Length; k++)
                    {
                        if (candidates[k] > t)
                        {
                            break;
                        }

                        if (candidates[k] == t)
                        {
                            var temp = new List<int>()
                            {
                                t
                            };
                            for (int jj = 0; jj < target / candidates[i] - j; jj++)
                            {
                                temp.Add(candidates[i]);
                            }
                            result.Add(temp);
                        }
                    }
                }
            }
        }
        return result;
    }
}
// @lc code=end

