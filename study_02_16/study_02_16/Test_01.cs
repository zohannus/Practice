using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test_01
{
    
    public void Main()
    {
        LinkedList<string> numbers = new LinkedList<string>();
        int count = 0;
        string Chat = "";
        while (true)
        {
            Chat = Console.ReadLine();
            if (Chat != "확인" && Chat != "취소" && count == 0)
            {

                numbers.AddLast(Chat);
            }
            else if (Chat == "확인" && count == 0)
            {
                foreach (var member in numbers)
                {
                    Console.WriteLine(member);
                }
                Chat = "";
            }
            else if(Chat == "취소")
            {
                count++;
                if (count == 1)
                {
                    Chat = Console.ReadLine();
                    numbers.Remove(Chat);
                    count = 0;
                }
            }
        }
    }
}
