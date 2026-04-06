public class Solution
{
    public bool IsPalindrome(string s)
    {
        string alphaNum = "";
        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsLetterOrDigit(s[i]))
            {
                alphaNum += s[i];
            }
        }
        // Console.WriteLine(alphaNum);

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
