class Solution 
{
    // This problem is similar to reverse words in a string

    private void ReverseArr(int[] arr, int i, int j)
    {
        while(i < j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i ++;
            j --;
        }
        return;
    }
    
    // Function to rotate an array by d elements in right direction.
    public void RotateArr(int[] arr, int d) 
    {
        int n = arr.Length;
        d %= n;
        ReverseArr(arr, 0, n - 1);
        ReverseArr(arr, 0, d - 1);
        ReverseArr(arr, d, n - 1);
    }
}