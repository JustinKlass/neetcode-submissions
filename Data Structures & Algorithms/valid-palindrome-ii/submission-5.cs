public class Solution
{
    public bool ValidPalindrome(string s)
    {

        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            if(s[left] != s[right])
            {
                return (IsPalindrome(s, left, right - 1) || IsPalindrome(s, left + 1, right));
            }

            left += 1;
            right -= 1;
        }


        return true;
    }

    private bool IsPalindrome(string s, int left, int right)
    {
        while(left < right)
        {
            if(s[left] != s[right])
            {
                return false;
            }

            left += 1;
            right -= 1;
        }

        return true;
    }
}