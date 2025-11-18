public class Solution 
{
    /**

    Here we can breakdown the problem into previously solved problem.
    Here we are deleting the extra spaces from the string the same way in the 
    problem where max freq is 2 and we were using 2 pointers technique in which
    checking before placing element at places.

    */

    private void ReverseString(StringBuilder ss, int i, int j)
    {
        while(i < j)
        {
            char ch = ss[i];
            ss[i] = ss[j];
            ss[j] = ch;
            i ++;
            j --;
        }
    }

    public string ReverseWords(string s) 
    {
        int n = s.Length;
        int lo = 0;
        int hi = 0;
        int it = 0;
        StringBuilder sb = new StringBuilder(s);
        ReverseString(sb, 0, n - 1);
        while(it < n)
        {
            while(it < n && sb[it] != ' ')
            {
                sb[hi] = sb[it];
                hi ++;
                it ++;
            }
            if(lo < hi)
            {
                ReverseString(sb, lo, hi - 1);
                if(hi < n)
                {
                    sb[hi] = ' ';
                }
                hi ++;
                lo = hi;
            }
            it ++;
        }
        return sb.ToString(0, hi - 1);
    }
}