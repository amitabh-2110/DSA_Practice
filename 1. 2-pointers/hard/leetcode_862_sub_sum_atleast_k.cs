
/**

    This problem is a variation of shortest subarray sum of atleast k where all the elements of
    the array are positive.

    In this problem, the elements can be negative as well. Also, need to be carefull when prob
    asking for max or min subarray sum and elements can be negative as well.

*/


public class Solution 
{
    public int ShortestSubarray(int[] nums, int k) 
    {
        int n = nums.Length;
        int ptr = 0;
        int minLen = int.MaxValue;
        long[] prefixSum = new long[n + 1];
        LinkedList<int> deque = new LinkedList<int>();

        for(int i = 0; i < n; i ++)
        {
            prefixSum[i + 1] = nums[i] + prefixSum[i];
        }
        while(ptr <= n)
        {
            while(deque.Count != 0 
                && prefixSum[ptr] < prefixSum[deque.Last.Value])
            {
                deque.RemoveLast();
            }
            deque.AddLast(ptr);
            while(deque.Count != 0 
                && prefixSum[ptr] - prefixSum[deque.First.Value] >= k)
            {
                minLen = Math.Min(minLen, ptr - deque.First.Value);
                deque.RemoveFirst();
            }
            ptr ++;
        }
        return minLen == int.MaxValue ? -1 : minLen;
    }
}