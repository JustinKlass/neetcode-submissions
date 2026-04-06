public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        bool isPal = true;

        while(left < right)
        {
            if(s[left] != s[right])
            {
                isPal = false;
            }

            left += 1;
            right -= 1;
        }

        if(isPal)
        {
            return true;
        }



        for(int middle = 0; middle < s.Length; middle++)
        {
            left = 0;
            right = s.Length - 1;
            bool isRemovedPal = true;

            while(left < right)
            {
                if(left == middle)
                {
                    left += 1;
                }

                if(right == middle)
                {
                    right -= 1;
                }

                if(s[left] != s[right])
                {
                    isRemovedPal = false;
                    break;
                }

                left += 1;
                right -= 1;
            }

            if(isRemovedPal)
            {
                return true;
            }
        }

        return false;
    }
}