public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int n = numbers.Length;
        int st = 0, end = n - 1;
        while(st < end) 
        {
            int sum = numbers[st] + numbers[end];
            if(sum == target)
            {
                return new int[] { st + 1, end + 1 };
            }
            else if(sum < target)
            {
                st ++;
            }
            else
            {
                end --;
            }
        }
        return new int[0];
    }
}