using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Hangman2
{
    Dictionary<int, string> Word = null;
    public void Main()
    {
        List<string> WordList = new List<string>();
        Word = new Dictionary<int, string>()
        {
            {0, "apple"},
            {1, "banana"}
        };
        int Life = 10;
        string Answer = "";
        int randomValue;

        //--- 랜덤값으로 단어선택
        Random randomNum = new Random();
        randomValue = randomNum.Next(2);
        if (randomNum != null)
            Answer = Word[randomValue];

        foreach (var word in Answer)
        {
            WordList.Add(word.ToString());
        }
        //--- 랜덤값으로 단어 선택

        for (int i = 0; i < Answer.Length; i++)
        {
            Console.Write("ㅡ");
        }
        Console.WriteLine();

        Console.WriteLine($"정답은? 남은횟수 :{Life}");

        //--- 단어 정답 체크
        //foreach (var Alpha in Answer)
        //{
        //    if (Word.ContainsKey(Alpha))
        //    {
        //        Word[Alpha]++;
        //    }
        //    else
        //    {
        //        Word[Alpha] = 1;
        //    }
        //}

        while (true)
        {
            string Chat = Console.ReadLine();
            if (Word.ContainsValue(Chat))
            {
                Console.WriteLine($"굿");
                for (int i = 0; i < Answer.Length; i++)
                {
                    if (WordList[i]== Chat)
                    {
                        Console.Write(Chat);
                    }
                    else
                        Console.Write("ㅡ");
                }
            }
            else
            {
                Console.WriteLine($"0개 포함하고 있습니다.");
                Life--;

                if (Life == 0)
                    Console.WriteLine("패배하였습니다.");
            }
        }
    }
}