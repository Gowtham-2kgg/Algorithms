using Algorithms.Trees;

namespace proj.Algoritms.Dp;

public class HuffmanCode
{
    //Instead of BSt we need heap but we implemented BST same like heap so no problems
    public void HuffMan(BinarySearchTree HuffMan, int[] values)
    {
        var t=new PriorityQueue<BinarySearchTree,int>();
        //sort values in descending order
        for (int i = 0; i < 10; i++)
        {
            var p = new BinarySearchTree();
            p.Value = values[i];
            p.LeftChild = null;
            p.RightChild = null;
            
            t.Enqueue(p,i);
        }

        var priority = t.Count - 1;

        while(t.Count>0)
        {
            var temp1 = t.Peek();
            t.Dequeue();
            priority--;
            var temp2 = t.Peek();
            t.Dequeue();

            var bst = new BinarySearchTree();
            bst.Value = temp1.Value + temp2.Value;

            bst.LeftChild = temp2;
            bst.RightChild = temp1;
            t.Enqueue(bst,priority);

        }
    }
}