public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {

        int index = 0;
        string output = "";

        // Loop through both words while there are still characters in at least one of them
        while(index < word1.Length || index < word2.Length)
        {
            // Check if index has finished the first word
            if(index < word1.Length)
            {
                // It has not. Add the current character
                output += word1[index];
            }

            // Check if index has finished the second word
            if(index < word2.Length)
            {
                // It has not. Add the current character
                output += word2[index];
            }

            // Increment the index
            index += 1;
        }

        // Return the combined word
        return output;
    }
}