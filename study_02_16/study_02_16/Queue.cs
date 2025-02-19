using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Queue<T>
{
    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="t">The element to be added to the queue.</param>
    /// 
    public T[] Skill = new T[10];
    public int count = 0;
    public void Enqueue(T t)
    {
        if (count >= Skill.Length)
        {
            Console.WriteLine("스킬 목록이 가득찼습니다.");
        }
        else if (count < Skill.Length)
        {
            Skill[count] = t;
            Console.WriteLine($"{count + 1}번째 스킬 {Skill[count]} 이 / 가 설정되었습니다.");
            count++;
        }
    }

    /// <summary>
    /// Removes and returns the element at the front of the queue.
    /// </summary>
    /// <returns>The element at the front of the queue.</returns>
    public T Dequeue()
    {
        count--;
        T Value = Skill[0];
        Skill[0] = default(T);
        for (int i = 1; i < Skill.Length; i++)
        {
            Skill[i - 1] = Skill[i];
        }
        if (count == Skill.Length - 1)
            Skill[Skill.Length - 1] = default(T);
        return Value;
    }

    /// <summary>
    /// Returns the element at the front of the queue without removing it.
    /// </summary>
    /// <returns>The element at the front of the queue.</returns>
    public T Peek()
    {
        if (Skill[0] == null)
            Console.WriteLine("스킬을 설정하지 않았습니다.");
        return Skill[0];
    }


    /// <summary>
    /// Gets the total number of elements currently in the queue.
    /// </summary>
    /// <returns>The number of elements in the queue.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Removes all elements from the queue, leaving it empty.
    /// </summary>
    public void Clear()
    {
        if (count == 0)
            Console.WriteLine("이미 비어있습니다.");
        for (int i = 0; i < Skill.Length; i++)
        {
            Skill[i] = default(T);
        }
    }


    /// < summary >
    /// Determines whether the queue is empty.
    /// </summary>
    /// <returns>True if the queue contains no elements; otherwise, false.</returns>
    public bool IsEmpty()
    {
        return count != 0;
    }
}

