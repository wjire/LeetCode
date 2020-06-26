/*
 * @lc app=leetcode.cn id=203 lang=csharp
 *
 * [203] 移除链表元素
 *
 * https://leetcode-cn.com/problems/remove-linked-list-elements/description/
 *
 * algorithms
 * Easy (42.76%)
 * Likes:    398
 * Dislikes: 0
 * Total Accepted:    84.6K
 * Total Submissions: 185.1K
 * Testcase Example:  '[1,2,6,3,4,5,6]\n6'
 *
 * 删除链表中等于给定值 val 的所有节点。
 * 
 * 示例:
 * 
 * 输入: 1->2->6->3->4->5->6, val = 6
 * 输出: 1->2->3->4->5
 * 
 * 
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

using Demo.Model;

public partial class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        //1->2->6->3->4->5->6
        var node = new ListNode(0);
        node.next = head;
        var curr = head;
        var p = node;
        while (curr != null)
        {
            if (curr.val == val)
            {
                p.next = curr.next;
            }
            else
            {
                p = curr;
            }
            curr = curr.next;
        }
        return node.next;
    }
}



// @lc code=end