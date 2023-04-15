namespace proj.Algoritms.Sorting;

public class Bubble
{
    public void BullbelSortAlgorithm(int[] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i+1; j < arr.GetLength(0); j++)
            {
                if (arr[i] > arr[j])
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
        }
    }
}