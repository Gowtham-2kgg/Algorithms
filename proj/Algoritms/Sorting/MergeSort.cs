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
            DoMergeSort(arr,l,m,r)
        }
    }
}