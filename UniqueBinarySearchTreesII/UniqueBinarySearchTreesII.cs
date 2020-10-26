/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class UniqueBinarySearchTreesII {
    public IList<TreeNode> GenerateTrees(int n) 
    {
        if(n==0)
          return new List<TreeNode>();
        
        return GenerateTree(1,n);
    }
    
    public List<TreeNode> GenerateTree(int start,int end)
    {
        List<TreeNode> ans = new List<TreeNode>();
        
        if(start>end)
        {
            ans.Add(null);
            return ans;
        }
        
        List<TreeNode> lefts,rights;
        for(int i = start;i <= end;i++)
        {
            lefts = GenerateTree(start,i-1);
            rights = GenerateTree(i+1,end);
            
            foreach(TreeNode left in lefts)
            {
                foreach(TreeNode right in rights)
                {
                    TreeNode tn = new TreeNode(i);
                    tn.left=left;
                    tn.right=right;
                    ans.Add(tn);
                }
            }
        }
        
        return ans;
    }
}