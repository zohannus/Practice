using System;
using System.Data.Common;
using static Monster;

namespace Test_02
{
    class Battle
    {
        int Turn = 0;
        const int PlayerTurn = 0;
        const int ComputerTurn = 1;

        Skill_Info SkInfo = new Skill_Info();
        MonsterManager monster = new MonsterManager();

        Random Rand = new Random();


        public void Start()
        {

            //int ranchoice = 0; 
            //ranchoice = Rand.Next(monster.mobList.Count);
            //BattleStart(ranchoice);
        }

        public void BattleStart(int choice)
        {

            Monster mobData = monster.mobList[choice];
            while (CharacterStatus.Instance.Hp > 0 && mobData.Hp > 0)
            {
                if (Turn == PlayerTurn)
                {
                    int i = 0;
                    Console.Clear();
                    Console.WriteLine($"상대 : {mobData.Name} / {mobData.Hp} ");
                    Console.WriteLine("무엇을 할까?");
                    for (i = 0; i < Enum.GetValues(typeof(Skill)).Length; i++)
                    {
                        SkInfo.SkillType((Skill)i);
                        Console.WriteLine($"{i}.{SkInfo.SkillName}:{SkInfo.SkillInfo}");
                    }
                    Console.WriteLine($"{i}.도망가기 : ");

                    string chat = Console.ReadLine();
                    int.TryParse(chat, out int SkillChoice);

                    SkInfo.PlayerAtk((Skill)SkillChoice, mobData);
                    Thread.Sleep(1000);
                    Turn = 1;
                }
                else if (Turn == ComputerTurn)
                {
                    Console.WriteLine($"{mobData.Name} 턴"); //몬스터 변수로 바꾸기
                    Thread.Sleep(500);
                    Console.WriteLine($"{mobData.Name}의 공격! {monster.MobNormalAttack(choice)}");
                    CharacterStatus.Instance.Hp -= monster.mobDamage;
                    Console.WriteLine($"{CharacterStatus.Instance.Hp} 남았다.");
                    Thread.Sleep(1000);
                    Turn = 0;
                }

                if (CharacterStatus.Instance.Hp <= 0 || mobData.Hp <= 0)
                {
                    Console.WriteLine("배틀종료");
                    Turn = 0;
                }
            }
        }


    }
}