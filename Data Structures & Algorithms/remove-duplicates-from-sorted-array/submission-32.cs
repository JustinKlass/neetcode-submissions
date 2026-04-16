public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int left = 0;
        int right = 1;

        while(right < nums.Length)
        {
            if(nums[left] != nums[right])
            {
                left += 1;
                nums[left] = nums[right];
            }

            right += 1;
        }

        return left + 1;
    }
}