public class Solution
{
    public List<List<int>> FourSum(int[] nums, int target)
    {
        List<List<int>> results = new List<List<int>>();

        // Sort the array first
        Array.Sort(nums);

        // Loop through nums as the left most pointer
        for(int left = 0; left < nums.Length; left++)
        {
            // Check if the current left value is a duplicate
            if(left > 0 && nums[left] == nums[left - 1])
            {
                // Skip the duplicate
                continue;
            }

            // Loop through nums as the middle left pointer
            for(int midLeft = left + 1; midLeft < nums.Length; midLeft++)
            {
                // Check if the current middle left value is a duplicate
                if(midLeft > left + 1 && nums[midLeft] == nums[midLeft - 1])
                {
                    // Skip the duplicate
                    continue;
                }

                // Create pointers for the middle right and right values
                int midRight = midLeft + 1;
                int right = nums.Length - 1;

                // Find the leftover target after removing the current left and middle left values
                long subTarget = (long)target - (nums[left] + nums[midLeft]);

                // Start 2Sum while loop
                while(midRight < right)
                {
                    // Get the current sum of the mid right and right pointer
                    int currSum = nums[midRight] + nums[right];

                    // Current sum is too big
                    if(currSum > subTarget)
                    {
                        // Decrement right pointer to make next sum smaller
                        right -= 1;
                    }

                    // Current sum is too small
                    else if(currSum < subTarget)
                    {
                        // Increment the middle right pointer to make next sum bigger
                        midRight += 1;
                    }

                    // We found our target sum
                    else
                    {
                        // Add the four values as a list to the results list
                        results.Add(new List<int>(){nums[left], nums[midLeft], nums[midRight], nums[right]});

                        // Decrement and increment the 2Sum pointers
                        right -= 1;
                        midRight += 1;

                        // Check the mid right pointer for duplicate values 
                        while(midRight < right && nums[midRight] == nums[midRight - 1])
                        {
                            // Skip the duplicates
                            midRight += 1;
                        }

                        // Check the right pointer for duplicate values
                        while(midRight < right && nums[right] == nums[right - 1])
                        {
                            // Skip the duplicates
                            right -= 1;
                        }
                    }
                }
            }
        }

        return results;    
    }
}