public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            if(!IsAlphaNum(s[left]))
            {
                left += 1;
            }

            else if(!IsAlphaNum(s[right]))
            {
                right -= 1;
            }

            else
            {
                if(char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }

                left += 1;
                right -= 1;
            }

        }   

        return true; 
    }

    private bool IsAlphaNum(char s)
    {
        if(s >= 'a' && s <= 'z' || s >= 'A' && s <= 'Z' || s >= '0' && s <= '9')
        {
            return true;
        }

        return false;
    }
}
