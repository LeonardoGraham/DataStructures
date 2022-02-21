namespace DataStructures;

// Doubly-Linked List
public class LinkedList<T>
{
    private LinkedListNode<T>? _list;

    public void Add(T value)
    {
        var node = new LinkedListNode<T>(value, _list);
        if (_list != null) _list.Previous = node;
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