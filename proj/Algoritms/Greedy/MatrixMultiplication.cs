namespace proj.Algoritms.Greedy;

public class MatrixMultiplication
{
    public void MatrixMulti(int[,] a,int [,] b)
    {
        int r1 = a.GetLength(0);
        int c1 = a.GetLength(1);
        int r2 = b.GetLength(0);
        int c2 = b.GetLength(1);
        int[,] result = new int[r1, c2];
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; j < r2; k++)
                {
                    result[i, j] = a[i, k] * b[i, k];
                }
            }
        }
    }
}