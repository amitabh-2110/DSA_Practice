public class Solution 
{
    public string MinWindow(string s, string t) 
    {
        Dictionary<char, int> Map = new Dictionary<char, int>();
        int m = s.Length;
        int n = t.Length;
        int countRequired = n;
        int stInd = -1;
        int minLen = int.MaxValue;
        int lo = 0;
        int hi = 0;
        foreach(char ch in t)
        {
            if(Map.ContainsKey(ch))
            {
                Map[ch] ++;
            }
            else
            {
                Map[ch] = 1;
            }
        }
        while(hi < m)
        {
            if(!Map.ContainsKey(s[hi]))
            {
                Map[s[hi]] = 0;
            }
            else if(Map[s[hi]] > 0)
            {
                countRequired --;
            }
            Map[s[hi]] --;
            while(countRequired == 0)
            {
                int len = hi - lo + 1;
                if(len < minLen)
                {
                    minLen = len;
                    stInd = lo;
                }
                Map[s[lo]] ++;
                if(Map[s[lo]] > 0)
                {
                    countRequired ++;
                }
                lo ++;
            }
            hi ++;
        }
        if(stInd == -1)
        {
            return string.Empty;
        }
        return s.Substring(stInd, minLen);
    }
}