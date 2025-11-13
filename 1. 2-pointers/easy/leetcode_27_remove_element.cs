public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int n = nums.Length;
        int l = n - 1, r = n;
        while(l >= 0)
        {
            if(nums[l] == val)
            {
                int temp = nums[l];
                nums[l] = nums[r - 1];
                nums[r - 1] = temp;
                r --;
            }
            l --;
        }
        return r;
    }
}