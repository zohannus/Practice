using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LinkedListNode<T>
{
    public string Member = "";
    public LinkedListNode<string> Next;

    public LinkedListNode(string member)
    {
        Member = member;
        Next = null;
    }
}

public class LinkedList<T>
{
    LinkedListNode<string> head;

    public LinkedList()
    {
        head = null;
    }
    public int Count()
    {
        return default;
    }

    public LinkedListNode<T> GetFirst()
    {
        return default;
    }

    public LinkedListNode<T> GetLast()
    {

        return default;
    }

    public LinkedListNode<T> AddFirst(T t)
    {
        return default;
    }

    public LinkedListNode<T> AddLast(T t)
    {
        return default;
    }

    public void RemoveFirst()
    {

    }

    public void RemoveLast()
    {

    }

    public bool Remove(T value)
    {
        return default;
    }

    public void Clear()
    {

    }


    public bool Contain(T value)
    {
        return default;
    }

    public LinkedListNode<T> Find(T value)
    {
        return default;
    }
}