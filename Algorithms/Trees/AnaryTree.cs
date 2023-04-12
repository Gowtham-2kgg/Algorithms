namespace Algorithms.Trees;
//Basic Form of tree where there is only one child for a parent in other word we can say its same as list
public class AnaryTree
{
    public AnaryTree Child { get; set; }
    public string Data { get; set; }

    public void Insert(AnaryTree tree)
    {
        this.Child = tree;
    }

    public void Delete(AnaryTree tree)
    {
        var Parser = this.Child;
        while (Parser != null)
        {
            if (Parser.Child == tree)
            {
                if (Parser.Child?.Child == null)
                {
                    Parser = null;
                }
                else
                {
                    var temp = Parser.Child.Child;
                    Parser.Child.Child = null;
                    Parser.Child = temp;
                }
            }
        }
    }

    public void Print(AnaryTree tree)
    {
        while (true)
        {
            Console.WriteLine(tree.Data);
            tree = tree.Child;
        }
    }
}
