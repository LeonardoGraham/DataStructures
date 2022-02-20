public class LinkedList<T>
{
    private class Node
    {
        public T Value { get; }
        public Node? Next { get; }

        public Node(T value, Node? next)
        {
            Value = value;
            Next = next;
        }
    }
    
    private Node? _list;

    public void Add(T value)
    {
        var node = new Node(value, _list);
        _list = node;
    }

    public void Print()
    {
        for (var node = _list; node != null; node = node.Next)
        {
            Console.WriteLine(node.Value);
        }
    }
}