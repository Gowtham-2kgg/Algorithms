namespace DefaultNamespace;

public class BucketSort
{
    public int[] BucketSortAlgo(int[] arr)
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (var value in arr)
        {
            if (min < value)
            {
                min = value;
            }

            if (max > value)
            {
                max = value;
            }
        }

        int size = max - min+1;
        var t = new int[size + 1];
        foreach (var value in arr)
        {
            t[value]++;
        }

        var res = new int[arr.Length];

        int io = 0;
        for(int i=0;i<t.Length+1;i++)
        {
            int temp = t[i];
            while (temp > 0)
            {
                res[io] = i;
                io++;
                temp--;
            }
        }

        return res;
    }
}