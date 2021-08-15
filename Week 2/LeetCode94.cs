using System.Collections.Generic;

namespace algorithmHomework{
    
    public class LeetCode94{
        List<int> result=new List<int>();
        public IList<int> InorderTraversal(TreeNode root) {
            if(root==null)
                return result;
            
            InorderTraversal(root.left);
            result.Add(root.val);
            InorderTraversal(root.right);
        }

        //Approach 2: iterative
        public IList<int> InorderTraversal2(TreeNode root) {
            List<int> list = new List<int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;

            while(cur!=null || stack.Count!=0){
                while(cur!=null){
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                list.Add(cur.val);
                cur = cur.right;
            }

            return list;
        }

        //Approach 3: Morris
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
    }
    }
}
