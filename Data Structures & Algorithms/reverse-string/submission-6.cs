public class Solution
{
    public void ReverseString(char[] s)
    {
        // Create left and right pointers
        int left = 0;
        int right = s.Length - 1;

        // Loop through s from start and end
        while(left < right)
        {

            // Swap characters at left and right positions
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            // Move pointers
            left += 1;
            right -= 1;
        }
    }
}