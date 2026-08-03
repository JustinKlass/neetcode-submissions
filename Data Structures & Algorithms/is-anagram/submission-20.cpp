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
            if(sCharMap.contains(s[i]))
            {
                sCharMap[s[i]] += 1;
            }

            else
            {
                sCharMap.insert({s[i], 0});
            }

            if(tCharMap.contains(t[i]))
            {
                tCharMap[t[i]] += 1;
            }

            else
            {
                tCharMap.insert({t[i], 0});
            }
        }


        return sCharMap == tCharMap;
    }
};
