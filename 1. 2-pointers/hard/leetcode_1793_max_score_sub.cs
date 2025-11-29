public class Solution 
{
    public int MaximumScore(int[] nums, int k) 
    {
        int lo = k;
        int hi = k;
        int n = nums.Length;
        int mini = nums[k];
        int score = int.MinValue;
        while(lo >= 0 && hi < n)
        {
            int lval = lo == 0 ? int.MinValue : nums[lo - 1];
            int rval = hi == n - 1 ? int.MinValue : nums[hi + 1];
            score = Math.Max(score, mini * (hi - lo + 1));

            if(lval >= rval)
            {
                mini = Math.Min(mini, lval);
                lo --;
            }
            else
            {
                mini = Math.Min(mini, rval);
                hi ++;
            }
        }
        return score;
    }
}