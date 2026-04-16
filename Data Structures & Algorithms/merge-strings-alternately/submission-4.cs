public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int first = 0;
        int second = 0;

        string res = "";

        while(first < word1.Length || second < word2.Length)
        {
            if(first < word1.Length)
            {
                res += word1[first];
                first += 1;
            }

            if(second < word2.Length)
            {
                res += word2[second];
                second += 1;
            }


        }   


        return res; 
    }
}