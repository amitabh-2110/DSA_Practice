public class Solution
{
    public int kDistinctChars(int k, string str)
    {
        Dictionary<char, int> Map = new Dictionary<char, int>();
        int n = str.Length;
        int lo = 0;
        int hi = 0;
        int count = 0;
        int maxLen = int.MinValue;
        while(hi < n)
        {
            if(!Map.ContainsKey(str[hi]) || Map[str[hi]] == 0)
            {
                count ++;
            }
            Map[str[hi]] ++;
            while(count > k)
            {
                Map[str[lo]] --;
                if(Map[str[lo]] == 0)
                {
                    count --;
                }
                lo ++;
            }
            maxLen = Math.Max(maxLen, hi - lo + 1);
            hi ++;
        }
        return maxLen;
    }
}