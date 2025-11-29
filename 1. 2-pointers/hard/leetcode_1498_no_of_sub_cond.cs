
/**

Here, there are some observations -

1. The no. of subsequence that will be formed in the given array will also be
formed when we rearrange the array. Now, how can we rearrange the array to solve
out problem ?

2. Now, how should we rearrange the array to get all the subsequence with min and
max value ? - Sort the array.

3. Here, to find no. of subsequence we need to find power of 2. We can use Pow()
function but it is not suitable. So, we can precompute the power as the max val
of (hi - lo) is (n - 1).

*/


public class Solution 
{
    private const int M = 1000000007;

    public int NumSubseq(int[] nums, int target) 
    {
        Array.Sort(nums);

        int n = nums.Length;
        int lo = 0;
        int hi = n - 1;
        int countSub = 0;
        int[] pow = new int[n];

        pow[0] = 1;
        for(int i = 1; i < n; i ++)
        {
            pow[i] = 2 * pow[i - 1] % M;
        }

        while(lo <= hi)
        {
            int sum = nums[lo] + nums[hi];
            if(sum <= target)
            {
                countSub = (countSub + pow[hi - lo]) % M;
                lo ++;
            }
            else 
            {
                hi --;
            }   
        }
        return countSub;
    }
}