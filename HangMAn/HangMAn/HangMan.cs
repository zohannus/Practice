﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


class HangMan
{
    Dictionary<int, char> Word = null;
    public void Main()
    {
        List<string> WordList = new List<string>() { "apple", "banana" };
        Word = new Dictionary<int, char>();
        int Life = 10;
        string Answer = "";
        int randomValue;
        
        //--- 랜덤값으로 단어선택
        Random randomNum = new Random();
        randomValue = randomNum.Next(2);
        if (randomNum != null)
            Answer = WordList[randomValue];
        //--- 랜덤값으로 단어 선택

        for (int i = 0; i < Answer.Length; i++)
        {
            Console.Write("ㅡ");
        }
        Console.WriteLine();

        Console.WriteLine($"정답은? 남은횟수 :{Life}");

        //---단어 정답 체크
        int Index = 0;
        foreach (var Alpha in Answer)
        {
            
            Word.Add(Index, Alpha);
            Index++;
        }
        for (int i = 0; i < Word.Count; i++)
        {
            Console.WriteLine(Word[i]);
        }
        while (true)
        {
            string Chat = Console.ReadLine();
            char CharChat = Chat[0];
            if (Word.ContainsValue(CharChat))
            {
                Console.WriteLine($"포함하고 있습니다.");
                for (int i = 0; i < Answer.Length; i++)
                {
                    if (CharChat == Word[i])
                    {
                        Console.Write(CharChat);
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

