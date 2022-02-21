namespace DataStructures;

public class BinaryTree
{
    private BinaryTreeNode? _tree;

    public void Add(int value)
    {
        var node = new BinaryTreeNode(value);
        
        // TODO
    }

    public bool Search(int value)
    {
        return SearchTree(_tree, value);
    }

    private static bool SearchTree(BinaryTreeNode? tree, int value)
    {
        if (tree == null)
            return false;
        if (value < tree.Value)
            return SearchTree(tree.Left, value);
        if (value > tree.Value)
            return SearchTree(tree.Right, value);
        
        return true;
    }

    public void Print()
    {
        PrintTree(_tree);
    }

    private static void PrintTree(BinaryTreeNode? root)
    {
        if (root == null)
            return;
        
        PrintTree(root.Left);
        Console.WriteLine(root.Value);
        PrintTree(root.Right);
    }
}