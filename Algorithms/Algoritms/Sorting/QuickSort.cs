namespace Algorithms.Algoritms.Sorting;

public class QuickSort
{
    public void QuickSortAlgo(int[] arr,int l,int h)
    {
        if (l < h)
        {
            int pivot = GetPivot(arr, l, h);
            if (pivot > 1)
            {
                QuickSortAlgo(arr, l, pivot);
            }

            if (pivot + 1 <= h)
            {
                QuickSortAlgo(arr, pivot, h);

            }
        }
    }

    private int GetPivot(int[] arr, int l, int r)
    {
        int pivot = l;
        while (true)
        {
            while (arr[l] < arr[pivot])
            {
                l++;
            }

            while (arr[pivot] < arr[r])
            {
                r--;
            }

            if (l < r)
            {
                int temp = arr[r];
                arr[r] = arr[l];
                arr[l] = temp;
            }
            else
            {
                return r;
            }
        }
    }
}