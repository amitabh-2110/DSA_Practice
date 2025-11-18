public class Solution 
{
    public int[] SortedSquares(int[] nums) 
    {
        int n = nums.Length;
        int[] res = new int[n];
        int i = 0;
        int j = n - 1;
        int k = n - 1;
        while(i <= j)
        {
            if(Math.Abs(nums[i]) >= Math.Abs(nums[j]))
            {
                res[k] = Math.Abs(nums[i]) * Math.Abs(nums[i]);
                i ++;
            }
            else
            {
                res[k] = Math.Abs(nums[j]) * Math.Abs(nums[j]);
                j --;
            }
            k --;
        }
        return res;
    }
}