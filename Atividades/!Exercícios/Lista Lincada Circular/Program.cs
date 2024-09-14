using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ObjectiveC;

public class CircularLinkedList<I> : LinkedList<I>
{
    public new IEnumerator<I> GetEnumerator()
    {
        return new CircularLinkedListEnumerator<I> (this);
    }
}
public class CircularLinkedListEnumerator<I> : IEnumerator<I>
{
    private LinkedListNode<I> _current;
    private LinkedList<I> _list;
    public I Current => _current.Value;
    object IEnumerator.Current => Current;
    public CircularLinkedListEnumerator(LinkedList<I> list)
    {
        _list = list;
        _current = null;
    }
    public bool MoveNext()
    {
        if (_current == null)
        {
            _current = _list.First;
        }
        else
        {
            _current = _current.Next ?? _list.First;
        }
        return _current != null;
    }
    public void reset ()
    {
        _current = null;
    }

    public void Dispose () { }
}
public static class CircularLinkedListExtensions
{
    public static LinkedListNode<I> Next<I>( this LinkedListNode<I> node)
    {
        if(node != null && node.List != null)
        {
            return node.Next ?? node.List.First;
        }
        return null;
    }
}
class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<int> circularList = new CircularLinkedList<int>();
        circularList.AddLast(1);
        circularList.AddLast(2);
        circularList.AddLast(3);

        foreach(var item in circularList)
        {
            Console.WriteLine(item);
        }
        LinkedListNode<int> current = circularList.First;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Current: {current.Value}");
            current = current.Next();
        }

    }
}