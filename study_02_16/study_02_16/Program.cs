using System;
using System.Runtime.Intrinsics.X86;

/// <summary>
/// Provides a generic stack data structure for storing and managing a collection of elements.
/// </summary>
/// <typeparam name="T">The type of elements in the stack.</typeparam>
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
        Items[count] = t; // ✅ 값 저장 확인
        Console.WriteLine($"{t} 아이템이 추가되었습니다. (현재 개수: {count + 1}/10)");
        count++; // ✅ 증가 위치 확인
    }



    /// <summary>
    /// Removes and returns the element at the top of the stack.
    /// </summary>
    /// <returns>The element removed from the top of the stack.</returns>
    public T Pop()
    {
        if (count == 0)
        {
            Console.WriteLine("스택이 비어 있어 삭제할 수 없습니다.");
            return default(T);
        }

        T item = Items[count-1]; // ✅ count 감소 후 요소 반환
        Items[count-1] = default(T); // ✅ 메모리 정리
        count--;
        return item;
    }

    /// <summary>
    /// Returns the element at the top of the stack without removing it.
    /// </summary>
    /// <returns>The element at the top of the stack.</returns>
    public T Peek()
    {
        Console.WriteLine(Items[count]);
        return default;
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
            Console.WriteLine($"-{i+1}슬롯 {Items[i]}");
        }
    }

    /// <summary>
    /// Gets the number of elements contained in the stack.
    /// </summary>
    /// <returns>The total number of elements in the stack.</returns>
    public int Count()
    {
        Console.WriteLine(count);
        return count;
    }

    /// <summary>
    /// Removes all elements from the stack.
    /// </summary>
    public void Clear()
    {
        for(int i = 0; i < count; i++)
        {
            Items[i] = default(T);
        }
        count = 0;
        Queue<int> a = new Queue<int>();
    }

    /// <summary>
    /// Determines whether the stack contains no elements.
    /// </summary>
    /// <returns>True if the stack is empty; otherwise, false.</returns>
    public bool IsEmpty()
    {
        return false;
    }
}

class ItemCall
{
    int depth = 0;
    Stack<string> stack = null;
    public void Main()
    {
        stack = new Stack<string>();
        Start();
    }

    void Start()
    {
        Console.Clear();
        int number = 0;
        string Chat = "";

        if (depth == 0)
        {
            while (depth == 0)
            {
                Console.WriteLine("원하는 메뉴를 선택해주세요. \n1. 아이템 입력 \n2. 아이템 확인 \n3. 가방비우기 \n4. 가방이 비어있는지 확인");
                Chat = Console.ReadLine();
                int.TryParse(Chat, out number);
                depth++;
            }
        }

        if (depth == 1)
        {
            if (number == 1)
            {
                while (number == 1 && depth == 1)
                {
                    Console.WriteLine($"아이템 수량 : ({stack.count}/10)");
                    Console.Write("최근 아이템 : ");
                    stack.Peek();
                    Console.WriteLine();
                    Console.Write("아이템명 :");
                    Chat = Console.ReadLine();
                    if (Chat != "취소" && Chat != "나가기")
                    {
                        stack.Push(Chat);
                    }
                    else if (Chat == "취소")
                    {
                        if (stack.count > 0)
                        {
                            Console.WriteLine($"{stack.Items[stack.count - 1]}이 / 가 삭제되었습니다.");
                            stack.Pop();
                        }
                        else
                            Console.WriteLine("삭제할 아이템이 없습니다");
                        Chat = "";
                    }
                    else if (Chat == "나가기")
                    {
                        depth = 0;
                        number = 0;
                        Start();
                    }
                }
            }
            else if (number == 2)
            {
                stack.Check();
            }

            else if (number == 3)
            {
                stack.Clear();
                Console.WriteLine("가방이 비워졌습니다.");
                Thread.Sleep(1000);
                Start();
                number = 0;
            }

            else if (number == 4)
            {
                Console.WriteLine("미구현");
            }
        }
    }
                    
         // While
    //void Main
} //class ItemCall
            


/// <summary>
/// Provides a generic queue data structure for storing and managing a collection of elements in a first-in, first-out (FIFO) order.
/// </summary>
/// <typeparam nam
/// e="T">The type of elements in the queue.</typeparam>
//public class Queue<T>
//{
//    /// <summary>
//    /// Adds an element to the end of the queue.
//    /// </summary>
//    /// <param name="t">The element to be added to the queue.</param>
//    public void Enqueue(T t)
//    {

//    }

//    /// <summary>
//    /// Removes and returns the element at the front of the queue.
//    /// </summary>
//    /// <returns>The element at the front of the queue.</returns>
//    public T Dequeue()
//    {
//        return default;
//    }

//    /// <summary>
//    /// Returns the element at the front of the queue without removing it.
//    /// </summary>
//    /// <returns>The element at the front of the queue.</returns>
//    public T Peek()
//    {
//        return default;
//    }


//    /// <summary>
//    /// Gets the total number of elements currently in the queue.
//    /// </summary>
//    /// <returns>The number of elements in the queue.</returns>
//    public int Count()
//    {
//        return 0;
//    }

//    /// <summary>
//    /// Removes all elements from the queue, leaving it empty.
//    /// </summary>
//    public void Clear()
//    {
//    }

//    /// <summary>
//    /// Determines whether the queue is empty.
//    /// </summary>
//    /// <returns>True if the queue contains no elements; otherwise, false.</returns>
//    public bool IsEmpty()
//    {
//        LinkedList<T> a = new LinkedList<T>();
//        a.
//        return false;
//    }
//}

//public class LinkedListNode<T>
//{

//}

//public class LinkedList<T>
//{
//    public int Count()
//    {

//    }

//    public LinkedListNode<T> GetFirst()
//    {

//    }

//    public LinkedListNode<T> GetLast()
//    {

//    }

//    public LinkedListNode<T> AddFirst(T t)
//    {

//    }

//    public LinkedListNode<T> AddLast(T t)
//    {

//    }

//    public void RemoveFirst()
//    {

//    }

//    public void RemoveLast()
//    {

//    }

//    public bool Remove(T value)
//    {

//    }

//    public void Clear()
//    {

//    }


//    public bool Contain(T value)
//    {

//    }

//    public LinkedListNode<T> Find(T value)
//    {

//    }
//}