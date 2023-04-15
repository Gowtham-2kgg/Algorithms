namespace Algoritms.Dp;

public class DpExampleOne
{
    //Fibonacci is a good example of DP since DP involves optimal structure and overlapping sub problem using memoization
    public int Fibonacci(int n)
    {
        var dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        for (int i = 0; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
}