public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            while(left < right && !AlphaNum(s[left]))
            {
                left += 1;
            }

            while(left < right && !AlphaNum(s[right]))
            {
                right -= 1;
            }

            

            if(char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }

            left += 1;
            right -= 1;
        }

        return true;
    }

    private bool AlphaNum(char c)
    {
        return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z' || c >= '0' && c <= '9');
    }
}
