
namespace DefaultNamespace;

//Matrix used to represent connection between node
//can be both bidirectional and unidirectional
//can be also have values for the edges
public class Matrix
{
    public void SampleGraph()
    {
        int[,] graph = new int[4, 4];
        for (var i = 0; i < graph.GetLength(0); i++)
        {
            for (int j = 0; j < graph.GetLength(1); j++)
            {
                //t can be 1 it can represent both uni and bi directional also it can represent value
                var t = int.Parse(Console.ReadLine());
                graph[i,j] = t;
            }
        }
    }
}
//cons:memory is huge difficult to manipulate nodes