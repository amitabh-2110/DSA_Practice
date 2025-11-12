public class Solution 
{
    public void ReverseString(char[] s) 
    {
        int n = s.Count();
        int st = 0, end = n - 1;
        while(st <= end)
        {
            char temp = s[st];
            s[st] = s[end];
            s[end] = temp;
            st ++;
            end --;
        }
        return;
    }
}