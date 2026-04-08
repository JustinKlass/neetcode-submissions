public class Solution
{
    public int Trap(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;

        int maxArea = 0;

        int leftMax = height[left];
        int rightMax = height[right];

        while(left < right)
        {
            if(leftMax <= rightMax)
            {
                left += 1;
                leftMax = Math.Max(leftMax, height[left]);

                maxArea += leftMax - height[left];
            }

            else
            {
                right -= 1;
                rightMax = Math.Max(rightMax, height[right]);

                maxArea += rightMax - height[right];
            }
        }

        return maxArea;
    }
}
