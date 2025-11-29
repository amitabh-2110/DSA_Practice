
/**

    Just rearrange the equation and see which value we can maximize.

*/

public class Solution 
{
    public int FindMaxValueOfEquation(int[][] points, int k) 
    {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>
            (Comparer<int>.Create((x, y) => y.CompareTo(x)));

        int n = points.Length; // number of points
        int maxScore = int.MinValue;

        maxHeap.Enqueue(0, points[0][1] - points[0][0]);
        for(int j = 1; j < n; j ++)
        {
            while(maxHeap.Count != 0 
                && points[j][0] - points[maxHeap.Peek()][0] > k)
            {
                maxHeap.Dequeue();
            }
            if(maxHeap.Count != 0)
            {
                int i = maxHeap.Peek();
                int score = points[i][1] - points[i][0] 
                    + points[j][1] + points[j][0];
                maxScore = Math.Max(maxScore, score);
            }
            maxHeap.Enqueue(j, points[j][1] - points[j][0]);
        }
        return maxScore;
    }
}