namespace DefaultNamespace;
//Graph theory
/*
Bellman–Ford algorithm
Dijkstra's algorithm
Ford–Fulkerson algorithm
Kruskal's algorithm
Nearest neighbour algorithm
Prim's algorithm
Depth-first search
Breadth-first search
 */
public class List
{
    public void UndirectionalAndDirectionalExample()
    {
        var graph = new List<List<int>>();
        var input = new int[5, 5];
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                graph[i].Add(j);
                graph[j].Add(i);
                /*
                 * for Directional
                 * graph[i].Add(j)
                 */
            }
        }
    }
    public void WeightedExample()
    {
        var graph = new List<List<int>>();
        var edge = new List<List<int>>();
        var input =new int[5,5]
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                graph[i].Add(j);
                graph[j].Add(i);
                edge[i].Add(int.Parse(Console.ReadLine()));
                /*
                 * for Directional
                 * graph[i].Add(j)
                 */
            }
        }
    }
// we can use stack or any other collection
    public void TopologicalSort(int i,List<List<int>> graph,bool[] isVisited, Stack<int> stack)
    {
        isVisited[i] = true;
        foreach (var adjacent in graph[i].Where(adjacent => !isVisited[adjacent]))
        {
            TopologicalSort(adjacent,graph,isVisited, stack);
        }
        stack.Push(i);
        
    }

    public void Topological()
    {
        var stack = new Stack<int>();
        var graph = new List<List<int>>();
        bool[] isVisited = new bool[5];
        //get input for graph
        for (int i = 0; i < 5; i++)
        {
            if (!isVisited[i])
            {
                TopologicalSort(i, graph, isVisited, stack);
            }
        }
// print stack
    }
    //detecting cycles in a graph is same for both directed and not directed
    public void DedectCycle()
    {
        var graph = new List<List<int>>();
        bool[] isVisited = new bool[5];
        bool[] isCycle = new bool[5];
        for (int i = 0; i < 5; i++)
        {
            if (!isVisited[i])
            {
                if (DetectCycleInGraph(i, graph, isVisited, isCycle))
                {
                    //
                }
            }
        }

    }

    private bool DetectCycleInGraph(int node,List<List<int>> graph, bool[] isVisited, bool[] isCycle)
    {
        if (isCycle[node])
        {
            return true;
        }
        if (isVisited[node])
        {
            return false;
        }

        isCycle[node] = true;
        isVisited[node] = true;

        foreach (var nodes in graph[node])
        {
            if (DetectCycleInGraph(nodes, graph, isVisited, isCycle))
            {
                return true;
            }
        }

        isCycle[node] = false;
        return false;
    }
    //DFS we used dfs everywhere above
    public void DfsRecursive(int node,List<List<int>> graph, bool[] isVisited)
    {
        if (isVisited[node])
        {
            return;
        }

        isVisited[node] = true;
        Console.WriteLine(node);

        foreach (var adjs in graph[node])
        {
            DfsRecursive(adjs,graph,isVisited);
        }
    }

    public void Dfs(int node, List<List<int>> graph, bool[] isVisited, Stack<int> stack)
    {
        if (isVisited[node])
        {
            return;
        }
        stack.Push(node);
        while (stack.Count != 0)
        {
            node = stack.Pop();
            if (!isVisited[node])
            {
                Console.WriteLine(node);
                isVisited[node] = true;
            }

            foreach (var nodes in graph[node])
            {
                if (!isVisited[nodes])
                {
                    stack.Push(nodes);
                }
            }
        }
    }
    public void bfs(int node, List<List<int>> graph, bool[] isVisited, Queue<int> queue)
    {
        if (isVisited[node])
        {
            return;
        }
        queue.Enqueue(node);
        while (queue.Count != 0)
        {
            node = queue.Dequeue();
            if (!isVisited[node])
            {
                Console.WriteLine(node);
                isVisited[node] = true;
            }

            foreach (var nodes in graph[node])
            {
                if (!isVisited[nodes])
                {
                    queue.Enqueue(nodes);
                }
            }
        }
    }
    //Dijikstra is used to find shortest path
    public int FindMinValue(List<List<int>> graph, bool[] isVisited, int[] distance)
    {
        int min=Int32.MaxValue;
        int min_Index = 0;
        for (int i = 0; i < graph.Count; i++)
        {
            if (isVisited[i] == false && distance[i] <= min)
            {
                min = distance[i];
                min_Index = i;
            }
        }

        return min_Index;
    }

    public void DijisktraAlgorithm(int src, List<List<int>> graph)
    {
        bool[] isVisited = new bool[10];
        var distance = new int[10];

        for (int i = 0; i < 10; i++)
        {
            distance[i] = int.MaxValue;
            isVisited[i] = true;
        }

        distance[src] = 0;
        for (int i = 0; i < 10; i++)
        {
            int u = FindMinValue(graph, isVisited, distance);
            isVisited[u] = true;
            var t = new SortedSet<int>();
            var r=t[2]
            for (int v = 0; v < 10; v++)
            {
                if (!isVisited[v] && graph[u][v] != 0 &&
                    distance[u] != int.MaxValue &&
                    distance[u] + graph[u][v] < distance[v])
                    distance[v] = distance[u] + graph[u][v];
            }
        }
    }

}