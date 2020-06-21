/*
 * @lc app=leetcode.cn id=832 lang=csharp
 *
 * [832] 翻转图像
 *
 * https://leetcode-cn.com/problems/flipping-an-image/description/
 *
 * algorithms
 * Easy (73.11%)
 * Likes:    170
 * Dislikes: 0
 * Total Accepted:    32.4K
 * Total Submissions: 43.3K
 * Testcase Example:  '[[1,1,0],[1,0,1],[0,0,0]]'
 *
 * 给定一个二进制矩阵 A，我们想先水平翻转图像，然后反转图像并返回结果。
 * 
 * 水平翻转图片就是将图片的每一行都进行翻转，即逆序。例如，水平翻转 [1, 1, 0] 的结果是 [0, 1, 1]。
 * 
 * 反转图片的意思是图片中的 0 全部被 1 替换， 1 全部被 0 替换。例如，反转 [0, 1, 1] 的结果是 [1, 0, 0]。
 * 
 * 示例 1:
 * 
 * 
 * 输入: [[1,1,0],[1,0,1],[0,0,0]]
 * 输出: [[1,0,0],[0,1,0],[1,1,1]]
 * 解释: 首先翻转每一行: [[0,1,1],[1,0,1],[0,0,0]]；
 * ⁠    然后反转图片: [[1,0,0],[0,1,0],[1,1,1]]
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入: [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
 * 输出: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
 * 解释: 首先翻转每一行: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]]；
 * ⁠    然后反转图片: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
 * 
 * 
 * 说明:
 * 
 * 
 * 1 <= A.length = A[0].length <= 20
 * 0 <= A[i][j] <= 1
 * 
 * 
 */

// @lc code=start
public partial class Solution
{
    public int[][] FlipAndInvertImage(int[][] A)
    {
        //[[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
        for (int i = 0; i < A.Length; i++)
        {
            var l = A[i].Length;
            var e = l - 1;
            for (int j = 0; j < l; j++, e--)
            {
                if (e < j)
                {
                    break;
                }
                var temp = A[i][e];
                A[i][e] = A[i][j] ^ 1;
                A[i][j] = temp ^ 1;
            }
        }

        return A;
    }


    public int[][] MyFlipAndInvertImage(int[][] A)
    {
        //[[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
        for (int i = 0; i < A.Length; i++)
        {
            var l = A[i].Length;
            var e = l - 1;
            for (int j = 0; j < l; j++, e--)
            {
                if (j == e)
                {
                    A[i][j] = 1 - A[i][j];
                    break;
                }
                if (j > e)
                {
                    break;
                }
                var temp = A[i][e];
                A[i][e] = 1 - A[i][j];
                A[i][j] = 1 - temp;
            }
        }

        return A;
    }
}
// @lc code=end

