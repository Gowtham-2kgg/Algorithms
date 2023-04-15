namespace DefaultNamespace;

public class FloydWarshall
{
    //this algorithm is only on Graph
    public int[,] FloydWarshallAlgorithm(int [,] graph)
    {
        int g = graph.GetLength(0);

        int[,] dist = new int[g, g];

        for (int k = 0; k < g; k++)
        {
            for (int i = 0; i < g; i++)
            {
                for (int j = 0; j < g; j++)
                {
                    if(dist[i,j]>dist[i,k],dist[k,j]){
                        dist[i,j]=dist[i,k]+dist[k, j];
                    }
                }
            }
        }

        return dist;
    }
}