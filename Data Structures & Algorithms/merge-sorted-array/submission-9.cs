public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // Get the last position of the first array
        int lastPos = nums1.Length - 1;

        // While there are still non zero numbers to be processed in both arrays
        while(m > 0 && n > 0)
        {
            // Check if nums1 biggest value is bigger than nums2 biggest value
            if(nums1[m - 1] > nums2[n - 1])
            {
                // Make the current last pos nums1
                nums1[lastPos] = nums1[m - 1];
                m -= 1;
            }

            // Nums2 is bigger or equal
            else
            {
                // Make the current last pos nums2
                nums1[lastPos] = nums2[n - 1];
                n -= 1;
            }

            // Always updating lastPos so it must move
            lastPos -= 1;
        }

        // Make sure that there are no left over values in nums2
        while(n > 0)
        {
            // No need to compare anymore. Just fill them in
            nums1[lastPos] = nums2[n - 1];
            n -= 1;

            lastPos -= 1;
        }
    }
}