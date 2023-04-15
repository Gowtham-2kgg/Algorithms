namespace Algorithms.Algoritms.Sorting;

public class SelectionSort
{
    public void SelectionSortAlgo()
    {
        int n = 10;
        var arr = new int[10];
        //get inputs of arr
        for (int i = 0; i < n-1; i++)
        {
            int minIndex = 100000;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[i])
                {
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}