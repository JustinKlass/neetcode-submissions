class Solution
{
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs)
    {
        unordered_map<string, vector<string>> res;

        // Loop through the vector of words
        for(auto& str : strs)
        {
            // Create a vector to hold the count of each letter in the given word
            vector<int> charCount(26, 0);


            // Loop through each character in the given word
            for(char c : str)
            {
                // Add the current letter to the char count
                charCount[c - 'a']++;
            }

            // Convert the count of A into a string
            string key = to_string(charCount[0]);

            // Loop through the alphabet
            for(int i = 1; i < 26; i++)
            {
                // Create a string that is comma seperated to track the number of times each letter shows up
                key += ',' + to_string(charCount[i]);
            }

            // Use the alphabet count as the key and push back the current word to the results
            res[key].push_back(str);

        }

        // Create a vector to hold the answer
        vector<vector<string>> result;

        // Loop through res vector and grab each set of words
        for(const auto& pair : res)
        {
            // Push back the vector that was the value of res
            result.push_back(pair.second);
        }

        // Return the final result
        return result;
    }
};
