namespace Algoritms.Dp;

public class JobScheduling
{
    public void MaxProfitFromJob()
    {
        var jobsTime = new int[10, 2];//start time and end time
        var profit = new int[10];//profit from respective job
        var dp = new int[10];
        
            //jobs time should be sort based on end time
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j<i ; j++)
                {
                    if (jobsTime[i, 1] <= jobsTime[j, 0] && (profit[i] + dp[j] > dp[i]))
                    {
                        dp[i] = dp[j] + profit[i];
                    }
                }
                
            }
            //find the max
    }
}