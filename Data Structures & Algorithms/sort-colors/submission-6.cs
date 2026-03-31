public class Solution
{
    public void SortColors(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int middle = 0;

        while(middle <= right)
        {
            if(nums[middle] == 0)
            {
                int temp = nums[left];
                nums[left] = nums[middle];
                nums[middle] = temp;
                left += 1;
                middle += 1;
            }

            else if(nums[middle] == 2)
            {
                int temp = nums[right];
                nums[right] = nums[middle];
                nums[middle] = temp;
                right -= 1;
            }

            else
            {
                middle += 1;
            }

        }

    }
}