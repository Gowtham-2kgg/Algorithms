namespace Algorithms.Trees;
//Trees can be also called as graph with no cycle and fully connected
//many times- BST, Red-black Tree,AB-tree,B-tree, trie, heap, 23 tree

//BST will have two child which left subtree value is lesser than parent and right will be greater 
public class Trees
{
    public bool FindingTwoBstAreSame(BinarySearchTree? alice, BinarySearchTree? bob)
    {
        if ((alice == null && bob != null)||(alice!=null&&bob==null))
        {
            return false;
        }

        if (alice == null && bob == null)
        {
            return true;
        }

        if (alice.Value != bob.Value)
        {
            return false;
        }

        return FindingTwoBstAreSame(alice.LeftChild, bob.LeftChild) &&
               FindingTwoBstAreSame(alice.RightChild, bob.RightChild);
    }
}

public class BinarySearchTree
{
    public BinarySearchTree? LeftChild { get; set; }
    public BinarySearchTree? RightChild { get; set; }
    public int Value { get; set; }

    public BinarySearchTree Delete(BinarySearchTree root, int value)
    {
        if (root == null)
        {
            return null;
        }
        else if (root.Value > value)
        {
            root.LeftChild = Delete(root.LeftChild, value);
        }
        else if (root.Value < value)
        {
            root.RightChild = Delete(root.RightChild, value);
        }
        else
        {
            if (root.LeftChild == null && root.RightChild == null)
            {
                root = null;
                return root;
            }
            else if (root.LeftChild == null || root.RightChild == null)
            {
                if (root.LeftChild == null)
                {
                    root = root.RightChild;
                    return root;
                }
                else
                {
                    root = root.LeftChild;
                    return root;
                }
            }
            else
            {
                var min = 0;
                var temp = root.RightChild;
                while (temp != null)
                {
                    min = temp.Value;
                    temp = temp.LeftChild;
                }

                root.Value = min;
                root.RightChild = Delete(root.RightChild, min);
            }
        }

        return root;

    }

    public BinarySearchTree LowestCommonAncestor(BinarySearchTree root, BinarySearchTree node1,
        BinarySearchTree node2)
    {
        if (root == null)
        {
            return null;
        }

        if (root.Value == node1.Value || root.Value == node2.Value)
        {
            return root;
        }

        if ((root.Value > node1.Value && root.Value < node2.Value) ||
            ((root.Value < node1.Value && root.Value > node2.Value)))
        {
            return root;
        }

        if ((root.Value > node1.Value && root.Value > node2.Value))
        {
            return LowestCommonAncestor(root.LeftChild, node1, node2);
        }

        return LowestCommonAncestor(root.RightChild, node1, node2);
    }

    public void Insert(BinarySearchTree root, BinarySearchTree node)
    {
        if (root == null)
        {
            root = node;
        }

        if (root.Value > node.Value)
        {
            if (root.LeftChild == null)
            {
                root.LeftChild = node;
            }
            else
            {
                Insert(root.LeftChild,node);
            }
        }
        else
        {
            if (root.RightChild == null)
            {
                root.RightChild = node;
            }
            else
            {
                Insert(root.RightChild,node);
            }
            
        }
    }
public void LevelOrderTraversal(){
//using list and dictionary
}
    //tocheck if BST is a BST
    public bool ValidateBst(BinarySearchTree root)
    {
        if (root == null)
        {
            return true;
        }

        var min = int.MaxValue;
        var max = int.MinValue;

        if (root.RightChild != null)
        {
            var right = root.RightChild;
            while (right != null)
            {
                if (min > right.Value)
                {
                    min = right.Value;
                }

                right = right.RightChild;
            }

            if (min < root.Value)
            {
                return false;
            }
        }
        if (root.LeftChild != null)
        {
            var left = root.LeftChild;
            while (left != null)
            {
                if (max < left.Value)
                {
                    max = left.Value;
                }

                left = left.LeftChild;
            }

            if (max > root.Value)
            {
                return false;
            }
        }

        return true && ValidateBst(root.LeftChild) && ValidateBst(root.RightChild);

    }

    public void Traversal(BinarySearchTree searchTree)
    {
        InOrder(searchTree);
        PreOrder(searchTree);
        PostOrder(searchTree);
    }

    private void PostOrder(BinarySearchTree searchTree)
    {
        if (searchTree == null)
        {
            return;
        }

        InOrder(searchTree.LeftChild);
        
        InOrder(searchTree.RightChild);
        
        Console.WriteLine(searchTree.Value);
    }

    private void PreOrder(BinarySearchTree searchTree)
    {
        if (searchTree == null)
        {
            return;
        }
        Console.WriteLine(searchTree.Value);
        
        InOrder(searchTree.LeftChild);
        
        InOrder(searchTree.RightChild);
    }

    private void InOrder(BinarySearchTree searchTree)
    {
        if (searchTree == null)
        {
            return;
        }
        InOrder(searchTree.LeftChild);
        Console.WriteLine(searchTree.Value);
        InOrder(searchTree.RightChild);
    }
	
}