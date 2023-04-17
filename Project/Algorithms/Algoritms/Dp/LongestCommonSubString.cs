namespace Algoritms.Dp;

public class LongestCommonSubString
{
    public void LongestCommonSubStringAlgorithm()
    {
        string a = "something";
        string b = "anything";
        var dp = new int[a.Length + 1, b.Length + 1];
        int max = int.MinValue;
        for (int i = 1; i <= a.Length; i++)
        {
            for (int j = 1; j <= b.Length; j++)
            {
                if (a.ToCharArray()[i - 1] == b.ToCharArray()[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                    if (dp[i, j] > max)
                    {
                        max = dp[i, j];
                    }
                }
                else
                {
                    dp[i, j] = 0;
                }
            }
        }
    }

    public void LongestCommonSubSequence()
    {
        string a = "something";
        string b = "anything";
        var dp = new int[a.Length + 1, b.Length + 1];
        int max = int.MinValue;
        for (int i = 1; i <= a.Length; i++)
        {
            for (int j = 1; j <= b.Length; j++)
            {
                if (a.ToCharArray()[i - 1] == b.ToCharArray()[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];

                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
    }
}