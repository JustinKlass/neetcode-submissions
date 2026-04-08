public class Solution
{
    public int MaxArea(int[] heights)
    {
        int maxArea = 0;

        int left = 0;
        int right = heights.Length - 1;

        while(left < right)
        {
            int height = Math.Min(heights[left], heights[right]);

            int area = height * (right - left);

            maxArea = Math.Max(maxArea, area);

            if(heights[left] >= heights[right])
            {
                right -= 1;
            }

            else
            {
                left += 1;
            }
        }

        return maxArea;
    }
}
