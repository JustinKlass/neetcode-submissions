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
    private List<int> inOrderList = new List<int>();

    public List<int> InorderTraversal(TreeNode root)
    {
        TraversalRecursive(root);
        return inOrderList;
    }

    private void TraversalRecursive(TreeNode node)
    {
        // If current node is null
        if(node == null)
        {
            // Go back up the tree
            return;
        }

        // Add all values to the left of current node
        TraversalRecursive(node.left);

        // Add current node value after left node
        inOrderList.Add(node.val);

        // Add right values after current node to make in order traversal complete
        TraversalRecursive(node.right);
    }
}