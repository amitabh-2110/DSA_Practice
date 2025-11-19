public class Solution 
{
    // similar problem to finding no. of subarrays whose product is less than k

    public int LongestOnes(int[] nums, int k) 
    {
        int n = nums.Length;
        int lo = 0;
        int hi = 0;
        int zeroCount = 0;
        int output = int.MinValue;
        while(hi < n)
        {
            if(nums[hi] == 0)
            {
                zeroCount ++;
            }
            while(zeroCount > k)
            {
                if(nums[lo] == 0)
                {
                    zeroCount --;
                }
                lo ++;
            }
            output = Math.Max(output, hi - lo + 1);
            hi ++;
        }
        return output;
    }
}