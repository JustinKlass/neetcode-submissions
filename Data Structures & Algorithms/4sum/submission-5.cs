public class Solution
{
    public List<List<int>> FourSum(int[] nums, int target)
    {
        List<List<int>> results = new List<List<int>>();
        Array.Sort(nums);

        for(int left = 0; left < nums.Length; left++)
        {
            if(left > 0 && nums[left] == nums[left - 1])
            {
                continue;
            }

            for(int midLeft = left + 1; midLeft < nums.Length; midLeft++)
            {
                if(midLeft > left + 1 && nums[midLeft] == nums[midLeft - 1])
                {
                    continue;
                }

                int midRight = midLeft + 1;
                int right = nums.Length - 1;

                long subTarget = (long)target - (nums[left] + nums[midLeft]);

                while(midRight < right)
                {
                    int currSum = nums[midRight] + nums[right];

                    if(currSum > subTarget)
                    {
                        right -= 1;
                    }

                    else if(currSum < subTarget)
                    {
                        midRight += 1;
                    }

                    else
                    {
                        results.Add(new List<int>(){nums[left], nums[midLeft], nums[midRight], nums[right]});
                        right -= 1;
                        midRight += 1;

                        while(midRight < right && nums[midRight] == nums[midRight - 1])
                        {
                            midRight += 1;
                        }

                        while(midRight < right && nums[right] == nums[right - 1])
                        {
                            right -= 1;
                        }
                    }
                }
            }
        }


        return results;    
    }
}