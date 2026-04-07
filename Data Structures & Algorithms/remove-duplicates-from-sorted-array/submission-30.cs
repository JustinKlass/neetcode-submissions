public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int slow = 0;
        int fast = 1;

        // Loop through nums
        while(fast < nums.Length)
        {
            // Check if nums[slow] is no longer unique
            if(nums[slow] != nums[fast])
            {
                // Increment slow then replace the next value
                slow += 1;
                nums[slow] = nums[fast];
            }

            // Fast pointer always moves
            fast += 1;

        }

        // Add one to slow. Its zero indexed
        return slow + 1;
    }
}


