public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right)
        {
            int currVal = numbers[left] + numbers[right];

            if(currVal == target)
            {
                return new int[]{left + 1, right + 1};
                
            }

            else if(currVal > target)
            {
                right -= 1;
            }

            else
            {
                left += 1;
            }
        }


        return null;
    }
}
