namespace DefaultNamespace;

public class KnapSack
{
    public void KnapImplementation(int[] wt, int[] profit, int weight)
    {
        int[,] dp = new int[profit.GetLength(0) + 1, weight + 1];

        for (int i = 0; i < wt.getLength(0); i++)
        {
            for (int w = 0; w < weight; w++)
            {
                if (i == 0 || w == 0)
                {
                    dp[i,j]=0;
                }

                else if (wt[i-1, j] <= wt)
                {
                    dp[i, j] = Math.Max(val[i-1]+dp[i-1,w-wt[i-1]], dp[i - 1, j]);
                }
                else
                {
                    dp[i, j] = dp[i - 1, j];
                }
            }
        }
    }
}