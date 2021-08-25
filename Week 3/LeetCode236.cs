using System.Collections.Generic;

namespace algorithmHomework{
    /*
    二叉树的最近公共祖先
    */
    public class LeetCode236{
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root ==null || root == p|| root==q) return root;
            TreeNode left=LowestCommonAncestor(root.left,p,q);
            TreeNode right=LowestCommonAncestor(root.right, p, q);

            if(left==null) return right;
            if(right==null) return left;

            return root;
        }

    }
}