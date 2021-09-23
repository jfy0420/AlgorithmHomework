using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
68. II. 二叉树的最近公共祖先
*/
    public class LeetCode68{
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            if(root==null|| root ==p || root== q)
                return root;
            
            TreeNode left=LowestCommonAncestor(root.left,p,q);
            TreeNode right=LowestCommonAncestor(root.right,p, q);

            if(left !=null && right !=null) return root;
            if(left !=null) return left;
            if(right!=null) return right;
            return null;
        }
    }
}