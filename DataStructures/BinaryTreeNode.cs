namespace DataStructures;

public class BinaryTreeNode
{
    public int Value { get; }
    public BinaryTreeNode? Left { get; set; }
    public BinaryTreeNode? Right { get; set;  }

    public BinaryTreeNode(int value)
    {
        Value = value;
    }
}