class Solution
{
public:
    vector<int> twoSum(vector<int>& nums, int target)
    {
        vector<int> ans;
        unordered_map<int, int> indiciesMap;

        for(int i = 0; i < nums.size(); i++)
        {
            if(!indiciesMap.contains(nums[i]))
            {
                indiciesMap.insert({target - nums[i], i});
            }

            else
            {
                ans = {indiciesMap[nums[i]], i};
                return ans;
            }
        }

        return ans;
    }
};
