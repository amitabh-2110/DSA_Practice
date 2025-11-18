class Solution 
{
    public int longestUniqueSubstr(string s) 
    {
        Dictionary<char, int> freqMap = new Dictionary<char, int>();
        int n = s.Length;
        int lo = 0;
        int hi = 0;
        int output = int.MinValue;
        while(hi < n)
        {
            if(freqMap.ContainsKey(s[hi]))
            {
                freqMap[s[hi]] ++;
            }
            else
            {
                freqMap.Add(s[hi], 1);
            }
            while(freqMap[s[hi]] > 1)
            {
                freqMap[s[lo]] --;
                lo ++;
            }
            output = Math.Max(output, hi - lo + 1);
            hi ++;
        }
        return output;
    }
}
