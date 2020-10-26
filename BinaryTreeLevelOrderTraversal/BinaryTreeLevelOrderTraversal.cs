/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class BinaryTreeLevelOrderTraversal {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        LO(res,root,0);
        return res;
    }
    
    public static void LO(IList<IList<int>> res,TreeNode tree,int level){
        if(tree == null) return;
        if(level >= res.Count) res.Add(new List<int>());
        res[level].Add(tree.val);
        LO(res,tree.left,level+1);
        LO(res,tree.right,level+1);
    }
}