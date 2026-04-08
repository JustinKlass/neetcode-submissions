public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        // List of lists to store answers
        List<List<int>> results = new List<List<int>>();

        // Sort the array
        Array.Sort(nums);


        // Loop through the entire array
        for(int left = 0; left < nums.Length; left++)
        {
            // If nums[left] is > 0 there can be no more possible numbers that add to 0 since it will always
            // be the smallest number
            if(nums[left] > 0)
            {
                break;
            }

            // Check if the current number is the same as last time
            if(left > 0 && nums[left] == nums[left - 1])
            {
                // It is. We can skip
                continue;
            }

            // Make a middle and right pointer
            int middle = left + 1;
            int right = nums.Length - 1;


            // Loop while middle is in between left and right
            while(middle < right)
            {
                // Get the current sum of the three pointers
                int sum = nums[left] + nums[middle] + nums[right];


                // Current sum too small. Increment middle pointer
                if(sum < 0)
                {
                    middle += 1;
                }


                // Current sum too big. Decrement right pointer
                else if(sum > 0)
                {
                    right -= 1;
                }

                // Found a valid answer
                else
                {
                    // Add it to the results list
                    results.Add(new List<int>(){nums[left], nums[middle], nums[right]});

                    // Update the pointers
                    middle += 1;
                    right -= 1;

                    // Increment middle while it is a duplicate of the last middle and in range
                    while(nums[middle] == nums[middle - 1] && middle < right)
                    {
                        middle += 1;
                    }
                }
            }
        }

        // Return list of lists
        return results;

    }
}