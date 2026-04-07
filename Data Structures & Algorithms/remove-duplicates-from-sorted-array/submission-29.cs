public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int slow = 0;
        int fast = 1;

        while(fast < nums.Length)
        {
            if(nums[slow] != nums[fast])
            {
                slow += 1;
                nums[slow] = nums[fast];
            }

            fast += 1;

        }

        return slow + 1;
    }
}