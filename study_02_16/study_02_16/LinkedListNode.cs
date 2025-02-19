using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class LinkedListNode
{
    public string Member = "";
    public int count = 0;
    public LinkedListNode Prev;
    public LinkedListNode Next;

    public LinkedListNode(string member)
    {
        Member = member;
        Next = null;
        Prev = null;
    }
}

public class LinkedList
{
    LinkedListNode head;

    public LinkedList()
    {
        head = null;
    }
    public int Count()
    {
        return default;
    }

    public LinkedListNode GetFirst()
    {
        return default;
    }

    public LinkedListNode GetLast()
    {

        return default;
    }

    public LinkedListNode AddFirst(string t)
    {
        return default;
    }

    public LinkedListNode AddLast(string t)
    {

        return default;
    }

    public void RemoveFirst()
    {
        
    }

    public void RemoveLast()
    {

    }

    public bool Remove(int value)
    {
        return default;
    }

    public void Clear()
    {

    }


    public bool Contain(string value)
    {
        return default;
    }

    public LinkedListNode Find(string value)
    {
        return default;
    }
}