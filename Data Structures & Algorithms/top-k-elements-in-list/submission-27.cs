public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int>[] freqs = new List<int>[nums.Length + 1];

        for(int i = 0; i < freqs.Length; i++)
        {
            freqs[i] = new List<int>();
        }

        foreach (int n in nums)
        {
            
            if (count.ContainsKey(n))
            {
                count[n] += 1;
            }
            else
            {
                count[n] = 1;
            }
        }


        foreach(var num in count)
        {
            freqs[num.Value].Add(num.Key);
        }

        int[] ans = new int[k];
        int index = 0;
        for(int i = freqs.Length - 1; i > 0 && index < k; i--)
        {
            foreach(int n in freqs[i])
            {
                ans[index++] = n;
                if(index == k)
                {
                    return ans;
                }
            }
        }

        return ans;
    }
}
