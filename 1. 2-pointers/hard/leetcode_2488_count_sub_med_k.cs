public class Solution 
{
    /**

    This problem can be broken down easily into problem of finding number of subarrays whose
    sum is k. For this median problem, we are NOT interested in finding elements left and right
    of k but the number of elements less than and more than k to find if k is median or not.

    */


    public int CountSubarrays(int[] nums, int k) 
    {
        Dictionary<int, int> Map = new Dictionary<int, int>();
        int n = nums.Length;
        int medInd = n;
        int suffixSum = 0;
        int prefixSum = 0;
        int countSub = 0;

        for(int i = 0; i < n; i ++)
        {
            if(nums[i] == k)
            {
                nums[i] = 0;
                medInd = i;
            }
            else if(nums[i] < k)
            {
                nums[i] = -1;
            }
            else
            {
                nums[i] = 1;
            }
        }
        for(int i = medInd; i < n; i ++)
        {
            suffixSum += nums[i];
            if(Map.ContainsKey(suffixSum))
            {
                Map[suffixSum] ++;
            }
            else
            {
                Map[suffixSum] = 1;
            }
        }
        for(int i = medInd; i >= 0; i --)
        {
            prefixSum += nums[i];
            if(Map.ContainsKey(-1 * prefixSum))
            {
                countSub += Map[-1 * prefixSum];
            }
            if(Map.ContainsKey(1 - prefixSum))
            {
                countSub += Map[1 - prefixSum];
            }
        }
        return countSub;
    }
}