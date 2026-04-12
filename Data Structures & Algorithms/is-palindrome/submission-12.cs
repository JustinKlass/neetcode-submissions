public class Solution
{
    public bool IsPalindrome(string s)
    {
        string alphaNum = "";

        // Loop through s to find alphanumeric characters
        for(int i = 0; i < s.Length; i++)
        {
            // Check if current character is alphanumeric
            if(char.IsLetterOrDigit(s[i]))
            {
                // Add it to the filtered string
                alphaNum += s[i];
            }
        }

        // Case insensitive so remove all capitals
        alphaNum = alphaNum.ToLower();

        int left = 0;
        int right = alphaNum.Length - 1;

        // Loop through alphanumeric characters
        while(left < right)
        {
            // Check if current characters match
            if(alphaNum[left] != alphaNum[right])
            {
                // They don't. Not a palindrome
                return false;
            }

            // Move pointers
            left += 1;
            right -= 1;
        }

        return true;
    }
}
