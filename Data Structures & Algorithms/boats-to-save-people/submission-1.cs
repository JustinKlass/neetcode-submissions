public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);

        int boatCount = 0;

        // Create opposite pointers
        int left = 0;
        int right = people.Length - 1;

        // Loop through people using opposite pointers
        while(left <= right)
        {
            // Make sure the pointers aren't pointing at the same person
            if(left != right)
            {
                // Get the combined weight
                int weight = people[left] + people[right];

                // Check if the weight is under the limit
                if(weight <= limit)
                {
                    // Left person can be added to the boat
                    left += 1;
                }
            }

            // Increment the amount of boats needed
            boatCount += 1;

            // Add the right person to the boat
            right -= 1;

        }

        return boatCount;
    }
}