public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        // Loop with two opposite pointers
        while(left < right)
        {
            // if current characters are not equal
            if(s[left] != s[right])
            {
                // Check if characters left to check can be a palindrome with either right or left
                return (IsPalindrome(s, left, right - 1) || IsPalindrome(s, left + 1, right));
            }

            // Move pointers
            left += 1;
            right -= 1;
        }
        
        // Valid palindrome
        return true;
    }


    private bool IsPalindrome(string s, int left, int right)
    {
        // Loop with Opposite pointers
        while(left < right)
        {
            // Characters are not equal
            if(s[left] != s[right])
            {
                // Not a palindrome
                return false;
            }

            // Move pointers
            left += 1;
            right -= 1;
        }

        // Valid palindrome
        return true;
    }
}