public class Solution 
{
    public int MinSubArrayLen(int target, int[] nums) 
    {
        int n = nums.Length;
        int minLen = int.MaxValue;
        int lo = 0;
        int hi = 0;
        int sum = nums[0];
        while(true)
        {
            while(sum < target)
            {
                hi ++;
                if(hi < n)
                {
                    sum += nums[hi];
                }
                else
                {
                    break;
                }
            }
            if(hi == n)
            {
                break;
            }
            while(sum >= target)
            {
                minLen = Math.Min(minLen, hi - lo + 1);
                sum -= nums[lo];
                lo ++;
            }
        }
        return minLen == int.MaxValue ? 0 : minLen;
    }
}