/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class ValidateBinarySearchTree {
    public bool IsValidBST(TreeNode root) {
        return helper(root,null,null);
    }
    
    public bool helper(TreeNode root,int? min,int? max)
    {
        if(root == null)
            return true;
        int val = root.val;
        if(min != null && val<=min) return false;
        if(max != null && val>=max) return false;
        
        if(!helper(root.left,min,val)) return false;
        if(!helper(root.right,val,max)) return false;
        return true;
    }
}