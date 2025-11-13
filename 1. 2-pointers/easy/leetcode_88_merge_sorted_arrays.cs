public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        /**
        
        If we start filling the nums1 from start considering to fill smaller 
        elements first then that can cause LOSS of elements in the num1.

        Instead we can try filling the nums1 from the end considering to fill
        larger elements first that doesn't cause the loss of elements and more
        cleaner design.

        */

        int p1 = m - 1;
        int p2 = n - 1;
        int p = m + n - 1;
        while(p1 >= 0 && p2 >= 0)
        {
            if(nums1[p1] >= nums2[p2])
            {
                nums1[p] = nums1[p1];
                p1 --;
            }
            else 
            {
                nums1[p] = nums2[p2];
                p2 --;
            }
            p --;
        }
        while(p2 >= 0)
        {
            nums1[p] = nums2[p2];
            p2 --;
            p --;
        }
    }
}