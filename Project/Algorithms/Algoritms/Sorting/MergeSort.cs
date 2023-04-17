namespace proj.Algoritms.Sorting;

public class MergeSort
{
    public void MergeSortAlgorthm(int[] arr,int l, int h)
    {

        if (h>l)
        {
            int m = (l + h) / 2;
            MergeSortAlgorthm(arr,l,m);
            MergeSortAlgorthm(arr,m+1,h);
            DoMergeSort(arr, l, m, h);
        }
    }

    public void DoMergeSort(int[] arr, int low, int mid, int high)
    {
        int n1 = mid - low;
        int n2 = high - mid;
        int[] arr1 = new int[n1];
        int[] arr2 = new int[n2];

        int i = 0;
        for (i = 0; i < n1; i++)
        {
            arr1[i] = arr[i];
        }
        for (i = 0; i < n1+n2; i++)
        {
            arr2[i] = arr[i];
        }

        i = 0;
        int j = 0;
        int k = 0;
        while (i < n1 && j < n2)
        {
            if (arr2[j] > arr1[i])
            {
                arr[k] = arr1[i];
                i++;
            }
            else
            {
                arr[k] = arr2[j];
                j++;
            }

            k++;
        }

        while (i < n1)
        {
            arr[k] = arr1[i];
            k++;
            i++;
        }
        while (j < n2)
        {
            arr[k] = arr1[j];
            k++;
            j++;
        }


    }
}