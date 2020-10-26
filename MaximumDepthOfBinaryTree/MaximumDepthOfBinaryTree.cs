/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class MaximumDepthOfBinaryTree {
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;
 
        int left = 1;
        int right = 1;
 
        left += MaxDepth(root.left);
        right += MaxDepth(root.right);
 
        return Math.Max(right,left);
    }
    
//     public int LeftRoot(TreeNode root,int count)
//     {
//         if(root.left==null)
//             return dic[root.val];
        
//         if(!dic.ContainsKey(root.left.val))
//             dic.Add(root.left.val,count+1);
        
//         return MaxDepth(root.left);
//     }
    
//     public int RightRoot(TreeNode root,int count)
//     {
//         if(root.right==null)
//             return dic[root.val];
        
//         if(!dic.ContainsKey(root.right.val))
//             dic.Add(root.right.val,count+1);
        
//         return MaxDepth(root.right);
//     }
}