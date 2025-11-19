using System;

class GFG
{
    static int binarySearch(int[] arr, int x)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (arr[mid] == x)
                return mid;
            if (arr[mid] < x)
                low = mid + 1;
            else
                high = mid - 1; }
        return -1; }
    public static void Main()
    {
        int[] arr = { 1, 2, 3,4,5,6};
        int n = arr.Length;
        int x = Convert.ToInt32(Console.ReadLine());
        int result = binarySearch(arr, x);
        if (result == -1)
            Console.WriteLine(
                "Element is not present in array");
        else
            Console.WriteLine("Element is present at "
                              + "index " + result);
    }
}
