public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int rot = k % nums.Length;

        int left = 0;
        int right = nums.Length - 1;

        ReverseArr(nums, left, right);

        left = 0;
        right = rot - 1;
        ReverseArr(nums, left, right);

        left = rot;
        right = nums.Length - 1;
        ReverseArr(nums, left, right);
    }

    private void ReverseArr(int[] nums, int left, int right)
    {
        while(left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;

            left += 1;
            right -= 1;
        }
    }

}