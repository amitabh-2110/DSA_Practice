public class Solution 
{
    public int NumRescueBoats(int[] people, int limit) 
    {
        Array.Sort(people);
        int n = people.Length;
        int pairs = 0;
        int lo = 0;
        int hi = n - 1;
        while(lo < hi)
        {
            int sum = people[lo] + people[hi];
            if(sum <= limit)
            {
                pairs ++;
                lo ++;
                hi --;
            }
            else
            {
                hi --;
            }
        }
        return n - pairs;
    }
}