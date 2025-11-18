public class Solution 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {
        int n = nums.Length;
        int res = int.MaxValue;
        int minSum = 0;
        Array.Sort(nums);
        for(int i = 0; i < n - 2; i ++)
        {
            int j = i + 1;
            int k = n - 1;
            int t = target - nums[i];
            while(j < k)
            {
                int sum = nums[j] + nums[k];
                int tsum = nums[i] + sum;
                int minDiff = Math.Abs(target - tsum);
                if(minDiff < res)
                {
                    res = minDiff;
                    minSum = tsum;
                }
                if(sum == t)
                {
                    break;
                }
                else if(sum < t)
                {
                    j ++;
                }
                else
                {
                    k --;
                }
            }
            while(i < n - 2 && nums[i] == nums[i + 1])
                i ++;
        }
        return minSum;
    }
}