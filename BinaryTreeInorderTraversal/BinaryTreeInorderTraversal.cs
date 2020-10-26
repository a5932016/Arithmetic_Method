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
public class BinaryTreeInorderTraversal {
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> list = new List<int>();
        TreeNode curr = root;
        TreeNode pre;

        while (curr != null)
        {
            if (curr.left == null)
            {
                list.Add(curr.val);
                curr = curr.right;
            }
            else
            {
                pre = curr.left;

                while (pre.right != null)
                {
                    pre = pre.right;
                }

                pre.right = curr.right;
                TreeNode tmp = curr;
                curr = curr.left;
                tmp.left = null;
            }
        }

        return list;
    }
}