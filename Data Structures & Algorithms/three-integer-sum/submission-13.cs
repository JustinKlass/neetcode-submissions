public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> results = new List<List<int>>();
        Array.Sort(nums);



        for(int left = 0; left < nums.Length; left++)
        {
            if(nums[left] > 0)
            {
                break;
            }

            if(left > 0 && nums[left] == nums[left - 1])
            {
                continue;
            }

            int middle = left + 1;
            int right = nums.Length - 1;

            while(middle < right)
            {
                int sum = nums[left] + nums[middle] + nums[right];

                if(sum == 0)
                {
                    results.Add(new List<int>(){nums[left], nums[middle], nums[right]});
                    middle += 1;
                    right -= 1;

                    while(nums[middle] == nums[middle - 1] && middle < right)
                    {
                        middle += 1;
                    }
                }

                else if(sum < 0)
                {
                    middle += 1;
                }

                else
                {
                    right -= 1;
                }
            }
        }

        return results;

    }
}
