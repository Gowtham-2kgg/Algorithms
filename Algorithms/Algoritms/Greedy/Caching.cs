namespace proj.Algoritms.Greedy;

public class Caching
{
    public void Fifo(List<int> data)
    {
        var stack = new Stack<int>();
        int max = 4;
        int hit, miss = 0;
        hit = 0;
        foreach (var val in data)
        {
            if (!stack.Contains(val))
            {
                miss++;
                if (stack.Count >= max)
                {
                    stack.Pop();
                }
                stack.Push(val);
            }
            else
            {
                hit++;
            }
        }
    }
    public void Lifo(List<int> data)
    {
        var queue = new Queue<int>();
        int max = 4;
        int hit, miss = 0;
        hit = 0;
        foreach (var val in data)
        {
            if (!queue.Contains(val))
            {
                miss++;
                if (queue.Count >= max)
                {
                    queue.Dequeue();
                }
                queue.Enqueue(val);
            }
            else
            {
                hit++;
            }
        }
    }

    public void Lru(List<int> data)
    {
        var list = new List<int>();
        var set = new HashSet<int>();
        int max = 4;
        int hit, miss = 0;
        hit = 0;
        foreach (var val in data)
        {
            if (!set.Contains(val))
            {
                if (list.Count == max)
                {
                    set.Remove(list[^1]);
                    list.Remove(list[^1]);
                }
            }
            else
            {
                list.Remove(list[^1]);
            }

            list.Insert(0, val);
            set.Add(val);
        }
    }
    public void Lfu(List<int> data)
    {
        var dict = new Dictionary<int, int>();
        int max = 4;
        int hit, miss = 0;
        hit = 0;
        foreach (var val in data)
        {
            if (!dict.ContainsKey(val))
            {
                if (dict.Count == max)
                {
                    FindAndDeleteLeastFrequent(dict);
                }
                dict[val] = 1;
                miss++;
            }
            else
            {
                dict[val] = dict[val] + 1;
                hit++;
            }

            
        }
    }

    private void FindAndDeleteLeastFrequent(Dictionary<int, int> dict)
    {
        int min_Freq = 10000;
        int key = 0980;
        foreach (var ver in dict)
        {
            if (ver.Value < min_Freq)
            {
                min_Freq = ver.Value;
                key = ver.Key;
            }
        }

        dict.Remove(key);
    }
}