using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Numerics;
using static Monster;




public class MainMenu
{
    CharacterStatus Status = new CharacterStatus();  //캐릭터 스텟 정보                 
    ItemList list = new ItemList();
    BagCtrl Item = new BagCtrl();
    Battle Battle = null;
    MonsterManager Mob = new MonsterManager();
    int Day = 1;
    bool ShopCan = true;

    public enum Location
    {
        Camp =0,
        Shop,
        ShopOut,
        Hunt,
        HuntStart
    }

    enum EquipWeapon
    {
        hand = 0,
        sword1 = 1,
        sword2 = 2,
        sword3 = 3
    }

    EquipWeapon equip = 0;
    Location Locate = 0;

    public void Start()
    { 
        Battle = new Battle();
        Console.WriteLine("이름을 정해주세요");
        string NameSet = Console.ReadLine();
        Status.CharacterName = NameSet;
        DataUpdate(Status.EquipCode);
        Camp();
    }

    void Camp()
    {
        Console.Clear();
        Console.WriteLine($"환영합니다, 용사 {Status.CharacterName}. 당신의 야영지입니다...");
        Console.WriteLine($"{Day} 일 차.");

        Locate = Location.Camp;
        while (Locate == Location.Camp)
        {
            int CampState = 0;
            Console.WriteLine("1. 이동\n2. 상자 열기\n3. 취침(체력,마나 소량 회복)");
            string Campchat = Console.ReadLine();
            int.TryParse(Campchat, out int Campint);
            if (Campint == 1 && CampState == 0)
            {
                CampState = 1;
                Console.Clear();
                Console.WriteLine("1. 사냥터\n2. 상점\n3. 돌아가기");

                Campchat = Console.ReadLine();
                int.TryParse(Campchat, out Campint);
                if (Campint == 1 && CampState == 1)
                {
                    Hunt();
                    CampState = 0;
                }
                else if (Campint == 2 && CampState == 1)
                {
                    Shop();
                    CampState = 0;
                }
                else if (Campint == 3 && CampState == 1)
                {
                    Camp();
                    CampState = 0;
                }
            }
            else if (Campint == 2 && CampState == 0)
            {
                Console.WriteLine("내 보유 아이템을 확인합니다.");
                Item.Bag();
            }
            else if (Campint == 3 && CampState == 0)
            {
                Console.WriteLine("체력이 모두 회복되었습니다.");
                Day++;
                continue;
            }
        }
    }

    void Hunt()  //사냥
    {
        Locate = Location.Hunt;
        Console.Clear();
        Console.WriteLine("사냥터로 가는 갈림길입니다.");
        while (Locate == Location.Hunt)
        {
            int HuntState = 0;
            int DungeonLvl = 0;        
            Console.WriteLine("1. 사냥하기\n2. 깊이 들어가기\n3. 돌아가기");
            string Huntchat = Console.ReadLine();
            int.TryParse(Huntchat, out int Huntint);

            if (Huntint == 1 && HuntState == 0)
            {
                HuntState = 1;
                //Console.Clear();
                int MonsterChoice;
                Random random = new Random();
                MonsterChoice = random.Next(Mob.mobList.Count);

                Console.WriteLine($"야생의 {Mob.mobList[MonsterChoice].Name} 를 만났다. 어떻게 할까?");

                Console.WriteLine("1. 전투\n2. 도망가기");
                Huntchat = Console.ReadLine();
                int.TryParse(Huntchat, out Huntint);
                if (Huntint == 1 && HuntState == 1)
                {
                    //Locate = Location.HuntStart;
                    Battle.BattleStart(MonsterChoice);
                }
                else if (Huntint == 2 && HuntState == 1)
                {
                    Console.WriteLine("도망쳤습니다.");
                    HuntState = 0;
                    continue;
                }
            }
            else if (Huntint == 2 && HuntState == 0)
            {
                Console.Clear();
                Console.WriteLine(" 더 깊은 곳으로 들어갑니다...");
                DungeonLvl++;
                Console.WriteLine(DungeonLvl);
            }
            else if (Huntint == 3 && HuntState == 0)
            {
                Camp();
            }
        }
    }

    public void Shop()      //상점
    {
        Locate = Location.Shop;
        while (Locate == Location.Shop)
        {
            Console.Clear();
            Console.WriteLine("상점에 오신것을 환영합니다. 구매 희망하는 아이템 코드를 입력하세요. ");
            Console.WriteLine($"소지금 :{Status.Money}");

            for (int i = 0; i < list.itemList.Length; i++)
            {
                Console.WriteLine($"{list.itemList[i].name}/ 가격 : {list.itemList[i].price} /코드 : {i} \nAtk:+{list.itemList[i].damage}\nAmr:+{list.itemList[i].amr}");
            }
            string chat = Console.ReadLine();

            if (int.TryParse(chat, out int number))
            {
                if (number >= 0 && number < list.itemList.Length)
                {
                    if (Item.count >= Item.bag.Length)
                    {
                        Console.WriteLine("가방이 가득찼습니다.");
                        ShopCan = false;
                        return;
                    }
                    if (Item.count < Item.bag.Length)
                    {
                        Console.Clear();
                        Console.WriteLine($"{list.itemList[number].name}을 구매했습니다.");
                        Status.Money -= list.itemList[number].price;
                        Item.bag[Item.count] = list.itemList[number];
                        Item.count++;
                    } 
                }
                else if (number == 9)
                {
                    Locate = Location.Camp;
                    break;
                }
            }
            else
            {
                Console.WriteLine("숫자를 입력하세요.");
            }
        }
    }
 

    void DataUpdate(int Code)
    {
        //Console.Clear();
        Console.WriteLine("캐릭터 이름 :" + Status.CharacterName);
        Console.WriteLine("체력 :" + Status.Hp);
        Console.WriteLine("공격력 :" + Status.Damage);
        Console.WriteLine("착용 장비 :");
        Console.WriteLine("소지금 :" + Status.Money);
    }
}
  



