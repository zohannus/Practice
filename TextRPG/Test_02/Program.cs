﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using Test_02;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{
    //static int time = 500;
    //static int delay = 1;
    //static int number = 1;
    static MainMenu test = null;  //구조체 연습 
    static Battle battle = null;
    static Monster mob = null;
    public static void Main()
    {
        Managers.Instance.Initialize();

        while (Managers.Run)
        {
            Managers.Instance.Update();
        }

        Managers.Instance.Release();


        battle = new Battle();
        test = new MainMenu();  //구조체 연습
        //test = new Class2();
        //Item.Main();
        //battle.Start();
        test.Start();
        
        //Console.WriteLine("==================\n 타 이 밍    게 임 \n made by zohannus \n==================");

        //Console.WriteLine(" 난이도를 설정해주세요. 3,5,10,20 중 입력");



        //Thread.Sleep(1000);

        //Console.Clear();

        //Console.WriteLine();

        //set();


        //while (true)
        //{

        //    timer();
        //}
    }

    class c1
    {
        
    }
    public void ProgramStart()
    {

    }


    //static void set()
    //{
    //    Random randomObj = new Random();
    //    number = randomObj.Next(20);
    //}


    //static void timer()
    //{
    //    //Thread.Sleep(time);
    //    //delay++;
    //    //Console.Write("I");
    //    if (delay < 20)
    //    {
    //        for (int i = 1; i <= 20; i++)
    //        {
    //            Console.WriteLine(delay);
    //            for (int s = 1; s <= i; s++)
    //            {
    //                pointup();
    //                Console.Write("I");
    //                pointdown();
    //            }
    //            delay++;
    //            Thread.Sleep(time);
    //            Console.WriteLine();
    //            Console.Clear();
    //        }
    //    }

    //    if (delay >= 20)
    //    {
    //        for (int i = 1; i <= 20; i++)
    //        {
    //            Console.WriteLine(delay);
    //            for (int s = 20; s >= i; s--)
    //            {
    //                pointup();
    //                Console.Write("I");
    //                pointdown();
    //            }
    //            delay--;
    //            Thread.Sleep(time);
    //            Console.WriteLine();
    //            Console.Clear();
    //        }
    //    }

    //}

    //static void pointup()
    //{
    //    for (int i = 1; i <= number; i++)
    //    {
    //        Console.Write(" ");

    //        if (i == number)
    //            Console.Write("↓");
    //    }
    //}

    //static void pointdown()
    //{
    //    for (int i = 1; i <= number; i++)
    //    {
    //        Console.Write(" ");

    //        if (i == number)
    //            Console.Write("↑");
    //    }
    //}
}
