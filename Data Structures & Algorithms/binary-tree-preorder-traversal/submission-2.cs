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
    List<int> preorderList = new List<int>();
    public List<int> PreorderTraversal(TreeNode root)
    {
        PreorderRecursive(root);
        return preorderList;
    }

    private void PreorderRecursive(TreeNode node)
    {
        if(node == null)
        {
            return;
        }

        preorderList.Add(node.val);
        PreorderRecursive(node.left);
        PreorderRecursive(node.right);
    }
}