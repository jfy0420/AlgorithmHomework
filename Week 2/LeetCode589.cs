using System.Collections.Generic;

namespace algorithmHomework{

    /*
    N 叉树的前序遍历
    */
    public class LeetCode589{
        
        //Approach 1: interative
        public IList<int> Preorder(Node root) {
            List<int> result=new List<int>();
            if(root==null)
                return result;
                 
            Stack<Node> stack=new Stack<Node>();
            stack.Push(root);

            while(stack.Count>0)
            {
                var root=stack.Pop();
                result.Add(root.val);
                for(int i=root.children.Count-1;i>=0;i++){
                    stack.Push(root.children[i]);
                }
            }
            return result;
        }

        //Approach 2: recursive
        List<int> result=new List<int>();
        public IList<int> Preorder2(Node root) {
            
            if(root==null)
                return result;
                 
            result.Add(root.val);
            foreach(var c in root.children)
            {
                Preorder2(c);
            }
            return result;
        }
    }

    public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
}