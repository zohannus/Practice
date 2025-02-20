using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HangMan
{
    Dictionary<string, int> Word = null;
    public void Main()
    {
        int Life = 10;
        List<string> WordList = new List<string>() {"apple" , "banana"};

        Word = new Dictionary<string, int>()
        {
            {"apple", 5},
            {"banana", 6 }
        };


        Random randomNum = new Random();
        int randomValue;
        randomValue = randomNum.Next(2);

        string Answer = "";
        if (randomNum != null)
            Answer = WordList[randomValue];

        Console.WriteLine();
        Console.WriteLine(Answer);

        for(int i = 0; i < WordList[randomValue].Length; i++)
        {
            Console.Write("ㅡ");
        }
        Console.WriteLine();

        Console.WriteLine($"정답은? 남은횟수 :{Life}");
        
    }
}

