class Solution
{
public:
    bool isAnagram(string s, string t)
    {

        unordered_map<char, int> sCharMap;
        unordered_map<char, int> tCharMap;

        if(s.length() != t.length())
        {
            return false;
        }

        for(int i = 0; i < s.length(); i++)
        {
            sCharMap[s[i]] += 1;
            tCharMap[t[i]] += 1;

        }


        return sCharMap == tCharMap;
    }
};
