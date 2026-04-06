public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int lastPosition = m + n - 1;

        while(m > 0 && n > 0)
        {
            // Check if current value in nums1 > nums2
            if(nums1[m - 1] > nums2[n - 1])
            {
                // It is. Change last position value to current nums1 value
                nums1[lastPosition] = nums1[m - 1];
                m -= 1;
            }

            // current value in nums2 >= nums1
            else
            {
                // Change last position value to current nums2 value
                nums1[lastPosition] = nums2[n - 1];
                n -= 1;
            }

            // Last position changed either way. Decrement it
            lastPosition -= 1;
        }

        // Edge case for when nums2 has left over values in it
        // (left over values are smaller than first element in nums1).
        while(n > 0)
        {
            // Last position is changed to current nums2 value
            nums1[lastPosition] = nums2[n - 1];

            // Decrement both n and last position
            n -= 1;
            lastPosition -= 1;
        }
    }
}