
/**

Few observations made -

1. Always calculate for smaller vertical.

2. If it is left - look for left_most and right - look for right_most.

3. Why we moved the smaller vertical
    - only the height of the smaller vertical matters, therefore after moving to the next
      vertical we can calculate water easily by considering leftMax only
    - to maximize the height

*/

public class Solution 
{
    public int Trap(int[] height) 
    {
        int n = height.Length;
        int lo = 0;
        int hi = n - 1;
        int lm = 0;
        int rm = 0;
        int total = 0;
        while(lo < hi)
        {
            if(height[lo] <= height[hi])
            {
                if(height[lo] > lm)
                {
                    lm = Math.Max(lm, height[lo]);
                }
                else
                {
                    total += (lm - height[lo]);
                }
                lo ++;
            }
            else 
            {
                if(height[hi] > rm)
                {
                    rm = Math.Max(rm, height[hi]);
                }
                else
                {
                    total += (rm - height[hi]);
                }
                hi --;
            }
        }
        return total;
    }
}