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
    List<int> postList = new List<int>();
    public List<int> PostorderTraversal(TreeNode root)
    {
        PostorderRecursive(root);
        return postList;
    }

    private void PostorderRecursive(TreeNode node)
    {
        if(node == null)
        {
            return;
        }

        PostorderRecursive(node.left);
        PostorderRecursive(node.right);
        postList.Add(node.val);
    }
}