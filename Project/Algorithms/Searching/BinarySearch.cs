namespace Project.Algorithms.Searching;

public class BinarySearch
{
    public int BinarySearchUtil(int[] arr,int low,int high, int element)
    {
        //the input array is already sorted
        if (low > high)
        {
            return -1;
        }

        int mid = (low + high) / 2;
        if (element == arr[mid])
        {
            return mid;
        }

        if (element < arr[mid])
        {
            return BinarySearchUtil(arr, low, mid, element);
        }

        return BinarySearchUtil(arr, mid, high, element);

    }
}