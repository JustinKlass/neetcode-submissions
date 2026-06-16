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
    int res = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        FindDiameter(root);
        return res;
    }


    private int FindDiameter(TreeNode node)
    {
        if(node == null)
        {
            return 0;
        }


        // Find height of left subtree
        int leftHeight = FindDiameter(node.left);

        // Find height of right subtree
        int rightHeight = FindDiameter(node.right);



        // Diameter through the current node is left + right
        int diameter = leftHeight + rightHeight;

        // Update the global answer with the diameter
        res = Math.Max(res, diameter);
        
        // Take the biggest height and add 1 to it and pass it back
        return 1 + Math.Max(leftHeight, rightHeight);
    }

}
