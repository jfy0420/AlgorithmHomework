using System.Collections.Generic;

namespace algorithmHomework{
    public class LeetCode24{
        //递归的思路
        public ListNode SwapPairs(ListNode head) {
            if(head==null || head.next==null)
                return head;

            ListNode result=head.next;
            head.next = SwapPairs(result.next);
            result.next = head;
            return result;
        }
    }

    /**
 * Definition for singly-linked list. */
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }

}