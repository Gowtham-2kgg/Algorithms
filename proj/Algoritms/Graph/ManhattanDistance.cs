namespace DefaultNamespace;
public class ManhattanDistance
{
    public void Algorrithm()
    {
        var t = new int[5, 2];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                t[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //find a max distance from one point to another like in graph with x,y coordinate
        int max = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                var ditance = Math.Abs(t[i, 0] - t[j, 0]) + Math.Abs(t[i, 1] - t[j, 1]);
                if (max < ditance)
                {
                    max = ditance;
                }
            }

            var asd = new Dictionary<string, string>();
            var yatst = new SortedSet<int>();
            yatst.Min();
            var s = "fwefvsd";
            s.Reverse();
        }
    }
}