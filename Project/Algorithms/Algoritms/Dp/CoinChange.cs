namespace DefaultNamespace;

public class CoinChange
{
    public void MinimumCoins(int[] coins, int total, int n)
    {
        //sort the coins by non decreasing order
        var t = new List<int>();
        for (int i = n - 1; i > 0; i--)
        {
            while (total >= coins[i])
            {
                total = total - coins[i];
                t.Add(coins[i]);
            }
        }

        Console.WriteLine(t.Count);
        
    }
    public int AllPossibleCoins(int[] coins, int total, int n)
    {
        //sort the coins by non decreasing order
        if (total == 0)
        {
            return 1;
        }

        return AllPossibleCoins(coins, total, n - 1) + AllPossibleCoins(coins, total - coins[n - 1], n);

    }
    
}