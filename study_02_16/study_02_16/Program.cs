using System;
using System.Runtime.Intrinsics.X86;

/// <summary>
/// Provides a generic stack data structure for storing and managing a collection of elements.
/// </summary>
/// <typeparam name="T">The type of elements in the stack.</typeparam>

class ItemCall
{
    int depth = 0;
    Stack<string> stack = null;
    Queue<string> queue = null;
    LinkedList<string> linked = null;
    public void Main()
    {
        stack = new Stack<string>();
        queue = new Queue<string>();
        linked = new LinkedList<string>();
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
                Console.WriteLine($"아이템 수량 : ({stack.count}/10)");
                Console.WriteLine("원하는 메뉴를 선택해주세요. \n1. 아이템 입력 \n2. 아이템 확인 \n3. 스킬 설정");
                Console.WriteLine($"가방 상태 : {stack.IsEmpty()}/{stack.Count()}/{stack.Items.Length}" +
                    $"\n스킬 슬롯 상태 :{queue.IsEmpty()}/{queue.Count()}/{queue.Skill.Length}");
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
                    Console.WriteLine($"최근 아이템 :{stack.Peek()}");
                    Console.Write("아이템명 :");
                    Chat = Console.ReadLine();
                    if (Chat != "취소" && Chat != "나가기" && Chat != "비우기")
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
                    else if (Chat == "비우기")
                    {
                        stack.Clear();
                        Console.WriteLine("가방이 비워졌습니다.");
                    }
                }
            }
            else if (number == 2)
            {
                stack.Check();
                Thread.Sleep(3000);
                number = 0;
                depth = 0;
                Start();
            }

            else if (number == 3)
            {
                Console.Clear();
                Console.WriteLine("1. 스킬설정하기 \n2. 나가기");
                depth++;
                Chat = Console.ReadLine();
                int.TryParse(Chat, out number);
                if (number == 1 && depth == 2)
                {
                    while (number == 1 && depth == 2)
                    {
                        Console.WriteLine("스킬이름을 입력해주세요");
                        Chat = Console.ReadLine();
                        if (Chat != "취소" && Chat != "나가기" && Chat != "확인" && Chat != "비우기")
                        {
                            queue.Enqueue(Chat);
                        }
                        else if (Chat == "취소")
                        {
                            if (queue.count > 0)
                            {
                                Console.WriteLine($"첫번째 스킬 {queue.Dequeue()} 가 삭제되었습니다.");
                            }
                            else
                                Console.WriteLine("삭제할 스킬이 없습니다");
                            Chat = "";
                        }
                        else if (Chat == "나가기")
                        {
                            depth = 0;
                            number = 0;
                            Start();
                        }
                        else if (Chat == "비우기")
                            queue.Clear();
                        else if (Chat == "확인")
                        {
                            Console.Clear();
                            Console.WriteLine($"현재 Peek 값 : {queue.Peek()} / count 값 : {queue.Count()} / IsEmpty 값 : {queue.IsEmpty()}");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write($"{i + 1} 슬롯 {queue.Skill[i]}");
                                if (i == 0)
                                    Console.Write(" <--이 스킬부터 사용됨");
                                Console.WriteLine();

                            }
                        }
                    }
                }
                else if (number == 2 && depth == 2)
                {
                    depth = 0;
                    number = 0;
                    Start();
                }

            }
        }


        // While
        //void Main
    } //class ItemCall

}



