public class Solution
{
    public void SortColors(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int middle = 0;

        while(middle <= right)
        {
            // Middle value was 0, left swap
            if(nums[middle] == 0)
            {
                // Swap
                int temp = nums[left];
                nums[left] = nums[middle];
                nums[middle] = temp;

                // Increment left and middle
                left += 1;
                middle += 1;
            }

            // Middle value was 2, right swap
            else if(nums[middle] == 2)
            {
                // Swap
                int temp = nums[right];
                nums[right] = nums[middle];
                nums[middle] = temp;

                // Decrement right. Don't increment middle because right could be a zero
                // If right is a zero, it will never get swapped if middle is incremented.
                right -= 1;
            }

            // Middle was a 1 and should stay in the middle
            else
            {
                middle += 1;
            }

        }

    }
}