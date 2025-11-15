public class Solution 
{
    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    public void SortColors(int[] nums) 
    {
        int n = nums.Length;
        int i = -1;
        int j = 0;
        int k = n;
        while(j < k)
        {
            if(nums[j] == 0)
            {
                Swap(nums, i + 1, j);
                i ++;
                j ++; // this is making sure there are no 2's in (i, j] so just place 0 to correct position and don't wait for 2 bec its not possible for 2 to come before j
            }
            else if(nums[j] == 2)
            {
                Swap(nums, j, k - 1);
                k --;
            }
            else
            {
                j ++;
            }
        }
        return;
    }
}