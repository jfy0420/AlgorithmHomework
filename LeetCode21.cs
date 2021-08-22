using System.Collections.Generic;

namespace algorithmHomework{
    /*
        合并两个有序链表
    */
    public class LeetCode21{
        //Option 1: recursive
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            //ListNode newList=new ListNode ();
            if(l1==null)
                return l2;
            
            if(l2==null)
                return l1;
            
            if(l1.val<l2.val){
                l1.next=MergeTwoLists(l1.next,l2);
                return l1;
            }
            else{
                l2.next=MergeTwoLists(l1,l2.next);
                return l2;
            }
        }

        //Option 2: iterative, dummy head;这个性能比recursive好
        public ListNode MergeTwoLists2(ListNode l1, ListNode l2) {
            ListNode dummyHead=new ListNode(-1);

            ListNode prev=dummyHead;
            while(l1!=null &&l2!=null){
                if(l1.val<l2.val){
                    prev.next=l1;
                    l1=l1.next;
                }
                else{
                    prev.next=l2;
                    l2=l2.next;
                }
                prev=prev.next;
            }

            prev.next=l1==null?l2:l1;

            return dummyHead.next;
        }
    }
}