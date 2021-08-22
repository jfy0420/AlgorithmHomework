using System.Collections.Generic;

namespace algorithmHomework{
    /*
    输入一个链表的头节点，从尾到头反过来返回每个节点的值（用数组返回）。
    */
    public class LeetCode6{
        List<int> a=new List<int>();

        //Option: use recursive, or stack
        public int[] ReversePrint(ListNode head) { 
            Reverse(head);
            return a.ToArray();
        }

        private void Reverse(ListNode node){
            //terminator
            if(node==null)
                return;
            
            Reverse(node.next);
            a.Add(node.val);
        }
    }
}