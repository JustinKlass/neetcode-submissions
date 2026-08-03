class Solution
{
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs)
    {
        unordered_map<string, vector<string>> res;

        for(auto& str : strs)
        {
            vector<int> charCount(26, 0);

            for(char c : str)
            {
                charCount[c - 'a']++;
            }

            string key = to_string(charCount[0]);
            for(int i = 1; i < 26; i++)
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
