/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class SearchInABinarySearchTree {
    public TreeNode SearchBST(TreeNode root, int val) 
    {
        if(root == null)
            return null;
        else if(root.val == val)
            return root;
        
        return val < root.val ? SearchBST(root.left,val) : SearchBST(root.right,val);
    }
}