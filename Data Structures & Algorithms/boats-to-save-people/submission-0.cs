public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);

        int boatCount = 0;

        int left = 0;
        int right = people.Length - 1;

        while(left <= right)
        {
            if(left != right)
            {
                int weight = people[left] + people[right];

                if(weight <= limit)
                {
                    left += 1;
                }
            }
            
            boatCount += 1;
            right -= 1;

        }

        return boatCount;
    }
}