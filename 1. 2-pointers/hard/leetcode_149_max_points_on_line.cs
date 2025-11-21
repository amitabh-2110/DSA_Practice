public class Solution 
{
    public int MaxPoints(int[][] points) 
    {
        // brute force

        // int n = points.Length;
        // if(n <= 2)
        // {
        //     return n;
        // }
        // int countPoints = 0;
        // for(int i = 0; i < n - 1; i ++)
        // {
        //     for(int j = i + 1; j < n; j ++)
        //     {
        //         int count = 2;
        //         int x1 = points[i][0];
        //         int y1 = points[i][1];
        //         int x2 = points[j][0];
        //         int y2 = points[j][1];
        //         double slopexy = 1d * (y2 - y1) / (x2 - x1);
        //         for(int k = 0; k < n; k ++)
        //         {
        //             if(k != i && k != j)
        //             {
        //                 int x3 = points[k][0];
        //                 int y3 = points[k][1];
        //                 double slopeyk = 1d * (y3 - y2) / (x3 - x2);
        //                 if(slopexy == slopeyk)
        //                 {
        //                     count ++;
        //                 }
        //             }
        //         }
        //         countPoints = Math.Max(countPoints, count);
        //     }
        // }
        // return countPoints;

        // optimised

        int n = points.Length;
        if(n == 1 || n == 2)
        {
            return n;
        }
        int maxPoints = 0;
        for(int i = 0; i < n; i ++)
        {
            Dictionary<double, int> Map = new Dictionary<double, int>(); 
            for(int j = 0; j < n; j ++)
            {
                if(j != i)
                {
                    int x1 = points[i][0];
                    int y1 = points[i][1];
                    int x2 = points[j][0];
                    int y2 = points[j][1];
                    double slope = 1d * (y2 - y1) / (x2 - x1);

                    if(Map.ContainsKey(slope))
                    {
                        Map[slope] ++;
                    }
                    else
                    {
                        Map[slope] = 1;
                    }
                }
            }
            int currpoints = Map.Values.Max() + 1;
            maxPoints = Math.Max(maxPoints, currpoints);
        }
        return maxPoints;
    }
}