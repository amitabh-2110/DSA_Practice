public class Solution 
{

    /**

        Here, if I want to find no. of subarrays between i and j then -

        no. of subarrays = 1 + 2 + 3 + ..... + j - i + 1

        We can calculate this using direct formula or we can also calculate while
        iterating from i to j like -

        for(int l = i; r <= j - i + 1; r ++)
            res = res + r - l + 1;
            
    */

    public int NumSubarrayProductLessThanK(int[] nums, int k) 
    {
        if(k == 0 || k == 1)
        {
            return 0;
        }
        int n = nums.Length;
        int l = 0;
        int r = 0;
        int p = 1;
        int res = 0;
        while(r < n)
        {
            p = p * nums[r];
            while(p >= k)
            {
                p = p / nums[l];
                l ++;
            }
            res = res + r - l + 1;
            r ++;
        }
        return res;
    }
}