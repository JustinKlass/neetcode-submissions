public class Solution
{
    public int Trap(int[] height)
    {
        // Create opposite pointers
        int left = 0;
        int right = height.Length - 1;

        int maxArea = 0;

        // Hold max height of left and right pointers
        int leftMax = height[left];
        int rightMax = height[right];

        // Loop through height using opposite pointers
        while(left < right)
        {
            // Check if left max height is smaller than right max height so far
            if(leftMax <= rightMax)
            {
                // Increment left pointer
                left += 1;

                // Update the left max height with the current left height if it's bigger
                leftMax = Math.Max(leftMax, height[left]);

                // Add water area to max area by using (left max wall - current left height)
                maxArea += leftMax - height[left];
            }

            // right max height is smaller than left max height so far
            else
            {
                // Decrement right pointer
                right -= 1;

                // Update the right max height with the current right height if it's bigger
                rightMax = Math.Max(rightMax, height[right]);

                // Add water area to max area by using (right max wall - current right height)
                maxArea += rightMax - height[right];
            }
        }

        return maxArea;
    }
}
