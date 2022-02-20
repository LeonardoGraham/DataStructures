namespace DataStructures;

public class LinkedListNode<T>
{
    public T Value { get; }
    public LinkedListNode<T>? Next { get; }

    public Node(T value, LinkedListNode<T>? next)
    {
        Value = value;
        Next = next;
    }
}