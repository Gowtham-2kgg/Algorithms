namespace proj.Algoritms.Dp;

public class CatalanNumbers
{
    //its very important algorithm
    //Permutation, Crossing matrix without diagonal, Possible BST from n elements, no of ways to create Binary tree with n+1 leaf
    //Parenthesis generation
    public int Catalan(int n)
    {
        int res = 0;
        if (n <= 1)
        {
            return 1;
        }

        for (int i = 0; i < n; i++)
        {
            res += Catalan(i) * Catalan(n - i - 1);
        }

        return res;
    }
}