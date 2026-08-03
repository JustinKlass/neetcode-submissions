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

            // Convert the count of chars into a string
            string key = to_string(charCount[0]);

            // Loop through the 
            for(int i = 0; i < 26; i++)
            {
                key += ',' + to_string(charCount[i]);
            }

            res[key].push_back(str);

        }

        vector<vector<string>> result;
        for(const auto& pair : res)
        {
            result.push_back(pair.second);
        }

        return result;
    }
};
