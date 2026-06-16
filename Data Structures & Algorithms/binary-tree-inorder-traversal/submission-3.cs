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
    List<int> list;
    public List<int> InorderTraversal(TreeNode root)
    {
        list = new List<int>();
        InOrderRecursive(root);
        return list;
    }

    public void InOrderRecursive(TreeNode node)
    {
        if(node == null)
        {
            return;
        }

        InOrderRecursive(node.left);
        list.Add(node.val);
        InOrderRecursive(node.right);

    }
}