public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        // Create two opposite pointers
        int left = 0;
        int right = numbers.Length - 1;
        
        // Loop through numbers while left is smaller than right
        while(left < right)
        {
            // Get current value
            int currVal = numbers[left] + numbers[right];

            // Check if we found the target
            if(currVal == target)
            {
                // Return the 1-indexed indicies
                return new int[]{left + 1, right + 1};
                
            }

            // Check if the current value is too big
            else if(currVal > target)
            {
                // Make value smaller by decrementing right pointer
                right -= 1;
            }

            // Number must be too small
            else
            {
                // Increment left pointer
                left += 1;
            }
        }

        // No value was found return null
        return null;
    }
}
