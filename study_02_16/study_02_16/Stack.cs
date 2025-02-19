using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stack<T>
{
    public T[] Items = new T[10];
    public int count = 0;

    /// <summary>
    /// Adds an element to the top of the stack.
    /// </summary>
    /// <param name="t">The element to be added to the stack.</param>
    /// 

    public void Push(T t)
    {
        if (count >= 10)
        {
            Console.WriteLine("가방이 가득찼습니다");
            return;
        }
        Items[count] = t;
        Console.WriteLine($"{t} 아이템이 추가되었습니다. (현재 개수: {count + 1}/10)");
        count++;
    }



    /// <summary>
    /// Removes and returns the element at the top of the stack.
    /// </summary>
    /// <returns>The element removed from the top of the stack.</returns>
    public T Pop()
    {
        if (count == 0)
        {
            Console.WriteLine("가방이 비어 있어 삭제할 수 없습니다.");
            return default(T);
        }

        var current = count - 1;
        T item = Items[current];
        Items[current] = default(T);
        count = current;
        return item;
    }

    /// <summary>
    /// Returns the element at the top of the stack without removing it.
    /// </summary>
    /// <returns>The element at the top of the stack.</returns>
    public T Peek()
    {
        if (count == 0)
            return default(T);
        else
            return Items[count - 1];
    }

    public void Check()
    {

        Console.WriteLine("현재 가방에 있는 아이템 목록:");

        if (count == 0)
        {
            Console.WriteLine("가방이 비어있습니다.");
            Thread.Sleep(1000);
            return;
        }
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"-{i + 1}슬롯 {Items[i]}");
        }
    }

    /// <summary>
    /// Gets the number of elements contained in the stack.
    /// </summary>
    /// <returns>The total number of elements in the stack.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Removes all elements from the stack.
    /// </summary>
    public void Clear()
    {
        for (int i = 0; i <= count; i++)
        {
            Items[i] = default(T);
        }
        count = 0;

    }

    /// <summary>
    /// Determines whether the stack contains no elements.
    /// </summary>
    /// <returns>True if the stack is empty; otherwise, false.</returns>
    public bool IsEmpty()
    {
        return count != 0;
    }
}
