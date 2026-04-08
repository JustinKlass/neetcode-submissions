public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        // Mod k in case it's bigger than the length of nums
        int rot = k % nums.Length;

        // Create two opposite pointers
        int left = 0;
        int right = nums.Length - 1;

        // Reverse the entire array in place
        ReverseArr(nums, left, right);

        // Update opposite pointers to only look at first section of the array
        left = 0;
        right = rot - 1;

        // Reverse the new front of the array only
        ReverseArr(nums, left, right);

        // Update opposite pointers to look at second section of the array
        left = rot;
        right = nums.Length - 1;

        // Reverse the rest of the array
        ReverseArr(nums, left, right);
    }

    private void ReverseArr(int[] nums, int left, int right)
    {
        // Loop using opposite pointers
        while(left < right)
        {
            // Swap the values at left and right
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;

            // Move the pointers towards the middle
            left += 1;
            right -= 1;
        }
    }

}