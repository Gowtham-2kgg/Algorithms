namespace Project.Algorithms.Searching;

public class StringSearching
{
    public bool StringSearchAlgo(string str, string input, ref int a)
    {
        int n = str.Length;
        int m = input.Length;

        for (int i = 0; i < n - m; i++)
        {
            if (str.ToCharArray()[i] == input.ToCharArray()[0])
            {
                if (str.Substring(i, m).Equals(input))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public void Example()
    {
        int max = 0;
        StringSearchAlgo("adf", "324", ref max);
    }
    
}