public class Solution 
{
    /**

    Here we made an observation that we don't need numbers <= 0 and number > n, we only care
    about number between [1, n]. Now how to deal with numbers <= 0 and > n in array. First we
    can check if 1 is present, if not then we can return 1 but if present then we can replace
    all not needed numbers with 1.

    */

    public int FirstMissingPositive(int[] nums) 
    {
        int n = nums.Length;
        bool isOnePresent = false;

        foreach(int num in nums)
        {
            if(num == 1)
            {
                isOnePresent = true;
                break;
            }
        }
        if(!isOnePresent)
        {
            return 1;
        }
        for(int i = 0; i < n; i ++)
        {
            if(nums[i] <= 0 || nums[i] > n)
            {
                nums[i] = 1;
            }
        }
        for(int i = 0; i < n; i ++)
        {
            int num = Math.Abs(nums[i]);
            if(nums[num - 1] > 0)
            {
                nums[num - 1] *= -1;
            }
        }
        for(int i = 0; i < n; i ++)
        {
            if(nums[i] > 0)
            {
                return i + 1;
            }
        }
        return n + 1;
    }
}