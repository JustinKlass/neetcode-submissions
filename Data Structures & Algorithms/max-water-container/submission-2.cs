public class Solution
{
    public int MaxArea(int[] heights)
    {
        int maxArea = 0;

        // Create opposite pointers
        int left = 0;
        int right = heights.Length - 1;

        // Loop through heights using opposite pointers
        while(left < right)
        {
            // Get the smallest height between the two current heights
            int height = Math.Min(heights[left], heights[right]);

            // Calculate the max amount of water that can be held
            int area = height * (right - left);

            // Update the new max area
            maxArea = Math.Max(maxArea, area);

            // Check the left height is greater or equal to the right height
            if(heights[left] >= heights[right])
            {
                // It is. Decrement the right pointer
                right -= 1;
            }

            // The left height is smaller than the right height
            else
            {
                // Increment the left pointer
                left += 1;
            }
        }

        return maxArea;
    }
}
