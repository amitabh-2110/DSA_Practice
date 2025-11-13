public class Solution 
{
    public int MaxArea(int[] height)
    {
        // for max area put pointers at end to maximise the base of the container
        
        /**

        IList<T> is not covariant means List<TypeA> is not a subtype of IList<TypeB> where TypeA
        derived from TypeB to maintain the type safety as List<T> have methods like Add() to
        manipulate the Collection.

        Whereas IEnumerable is covariant means List<List<int>> is subtype of 
        IEnumerable<IEnumerable<int>> as it is readonly.

        */

        int n = height.Length;
        int lo = 0;
        int hi = n - 1;
        int maxi = int.MinValue;
        while(lo < hi)
        {
            int area = (hi - lo) * Math.Min(height[lo], height[hi]);
            maxi = Math.Max(maxi, area);
            if(height[lo] <= height[hi])
            {
                lo ++;
            }
            else
            {
                hi --;
            }
        }
        return maxi;
    }
}