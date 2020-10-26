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
public class SameTree {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null)
            return true;
        else if(!check(p,q))
            return false;
        
        LinkedList<TreeNode> listp = new LinkedList<TreeNode>();
        LinkedList<TreeNode> listq = new LinkedList<TreeNode>();
        listp.AddLast(p);
        listq.AddLast(q);
        
        while(listp.Count != 0)
        {
            p = listp.First.Value;
            listp.RemoveFirst();
            
            q = listq.First.Value;
            listq.RemoveFirst();
            
            if(!check(p,q))
                return false;
            
            if(p != null)
            {
                if(!check(p.left,q.left))
                    return false;
                if(p.left != null)
                {
                    listp.AddLast(p.left);
                    listq.AddLast(q.left);
                }
                
                if(!check(p.right,q.right))
                    return false;
                if(p.right != null)
                {
                    listp.AddLast(p.right);
                    listq.AddLast(q.right);
                }
            }
        }
        
        return true;
    }
    
    public bool check(TreeNode left,TreeNode right)
    {
        if(left == null && right == null)
            return true;
        else if(left == null || right == null)
            return false;
        else if(left.val != right.val)
            return false;
        
        return true;
    }
}