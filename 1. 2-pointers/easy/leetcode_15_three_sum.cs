public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        List<IList<int>> res = [];
        int n = nums.Length;
        for (int i = 0; i < n - 2; i++)
        {
            int j = i + 1;
            int k = n - 1;
            int target = -nums[i];
            while (j < k)
            {
                int sum = nums[j] + nums[k];
                if (sum == target)
                {
                    List<int> resList = [nums[i], nums[j], nums[k]];
                    res.Add(resList);

                    while (j < k && nums[j] == nums[j + 1])
                        j++;
                    while (k > j && nums[k] == nums[k - 1])
                        k--;

                    j++;
                    k--;
                }
                else if (sum < target)
                {
                    j++;
                }
                else
                {
                    k--;
                }
            }

            while (i < n - 2 && nums[i] == nums[i + 1])
                i++;
        }
        return res;
    }
}