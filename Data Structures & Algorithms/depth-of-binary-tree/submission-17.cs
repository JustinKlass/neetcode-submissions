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

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        return MaxDepthRec(root, 0);    
    }

    private int MaxDepthRec(TreeNode node, int count)
    {
        if(node == null)
        {
            return count;
        }

        return Math.Max(MaxDepthRec(node.left, count + 1), MaxDepthRec(node.right, count + 1));
        
    }
}
