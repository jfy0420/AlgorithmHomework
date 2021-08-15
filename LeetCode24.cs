using System.Collections.Generic;

namespace algorithmHomework{
    public class LeetCode24{
        //递归的思路
        public ListNode SwapPairs(ListNode head) {
            if(head==null || head.next==null)
                return head;

            ListNode newHead=head.next;
            head.next = SwapPairs(newHead.next);
            newHead.next = head;
            return newHead;
        }

        //增加一个dummy node
        public ListNode SwapPairs1(ListNode head) {
            if(head==null || head.next==null)
                return head;

            ListNode dummyHead=new ListNode();
            dummyHead.next=head;
            ListNode temp=dummyHead;
            while(temp.next!=null && temp.next.next!=null)
            {
                ListNode node1=temp.next;
                ListNode node2=node1.next;
                temp.next=node2;
                node1.next=node2.next;
                node2.next=node1;
                temp=node1;
            }
            return dummyHead.next;
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