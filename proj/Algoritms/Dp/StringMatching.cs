namespace Algoritms.Dp;

public class StringMatching
{
    //same as edit distance
    public int MinimumChangesToMAkeStringSame(string one, string two)
    {
        int[,] dp = new int[one.Length+1,two.Length+1];

        for (int i = 0; i <= one.Length; i++)
        {
            for (int j = 0; j <= two.Length; j++)
            {
                if (i == 0)
                {
                    dp[i,j] = j;
                }

                else if (j == 0)
                {
                    dp[i, j] = i;
                }

                else if (one.ToCharArray()[i-1] == two.ToCharArray()[j-1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = 1 + Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1]));
                }
            }
        }

        return dp[one.Length, two.Length];
    }
}