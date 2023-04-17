namespace Project.Algorithms.Searching;

public class LinearSearch
{
    public int LinearSearchAlgo(int[] arr, int element)
    {
        int index = -1;
        foreach (var x in arr)
        {
            if (x == element)
            {
                index++;
                return index;
            }
        }
        
        return -1;
    }
}