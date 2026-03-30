public class Solution
{
    public int[] SortArray(int[] nums)
    {
        // Check if the array is only one value
        if(nums.Length == 1)
        {
            // It is. Return it
            return nums;
        }

        // Call Shell Sort
        ShellSort(nums, nums.Length);

        return nums;

    }

    private void ShellSort(int[] nums, int length)
    {
        // Create initial gap
        int gap = length / 2;

        // Loop while the gap is larger than 0
        while(gap >= 1)
        {
            // Loop through the second half of the gap
            for(int i = gap; i < length; i++)
            {
                // Save nums[i]
                int temp = nums[i];

                // Get position of the smaller element
                int j = i - gap;

                // Shift elements up
                while(j >= 0 && nums[j] > temp)
                {
                    nums[j + gap] = nums[j];
                    j -= gap;
                }

                // Insert element
                nums[j + gap] = temp;
            }

            // Shrink the gap
            gap /= 2;
        }
    }
}