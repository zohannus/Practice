using System;
using System.Data.Common;

class Battle
{
    int Turn = 0;
    const int PlayerTurn = 0;
    const int ComputerTurn = 1;

    // 플레이어 변수
    

    // 몬스터 변수
   
    float Randint;

    MainMenu Menu = null;
    Skill_Info SkInfo = new Skill_Info();
    CharacterStatus Status = null;

    Random Rand = new Random();
    Monster Mob = new Monster();

    public void Start()
    {
        Status = new CharacterStatus();
        Menu = new MainMenu();
    }

    public void BattleStart(int MonsterChoice)
    {
        //while (Status.Hp > 0 && Mob.Monst[MonsterChoice].Hp > 0) 
        //{
        if (Turn == PlayerTurn)
        {
            int i = 0;
            int MobNumber = 0;
            Console.Clear();
            Console.WriteLine($"상대 : {Mob.Monst[MonsterChoice].Name} / {Mob.Monst[MonsterChoice].Hp} ");
            MobNumber = MonsterChoice;
            Console.WriteLine("무엇을 할까?");
            for (i = 0; i < Enum.GetValues(typeof(Skill)).Length; i++)
            {
                SkInfo.SkillType((Skill)i);
                Console.WriteLine($"{i}.{SkInfo.SkillName}:{SkInfo.SkillInfo}");
            }
            Console.WriteLine($"{i}.도망가기 : ");

            string chat = Console.ReadLine();
            int.TryParse(chat, out int SkillChoice);

            PlayerAtt((Skill)SkillChoice, Mob.Monst[MobNumber].Hp, Mob.Monst[MobNumber].Amr);
        }
        else if (Turn == ComputerTurn)
        {
            Console.WriteLine("컴퓨터의 턴"); //몬스터 변수로 바꾸기
        }
        //}
    }
    void PlayerAtt(Skill SkType, float MonsterHp, float MonsterAmr)
    {
        float myDmg = ((Status.Att - MonsterAmr + Randint) * SkInfo.SkillDamage );
        if (SkType == Skill.Skill_0)
        {
            Console.Clear();
            SkInfo.SkillType(Skill.Skill_0);
            myDmg = ((Status.Att - MonsterAmr + Randint) * SkInfo.SkillDamage);
            Randint = Rand.Next(-3, 3);
            MonsterHp -= myDmg;                   // 플레이어의 데미지 : 10 에서 +- 5
            Console.WriteLine($"{SkInfo.SkillName} 사용..{myDmg}의 타격..!! \n 적의 체력 :{MonsterHp}");
        }
        else if (SkType == Skill.Skill_1)
        {
            Console.Clear();
            SkInfo.SkillType(Skill.Skill_1);
            myDmg = ((Status.Att - MonsterAmr + Randint) * SkInfo.SkillDamage);
            Randint = Rand.Next(-3, 3);
            MonsterHp -= myDmg;                   // 플레이어의 데미지 : 10 에서 +- 5
            Console.WriteLine($"{SkInfo.SkillName} 사용..{myDmg}의 타격..!! \n {MonsterHp} 남았다.");
        }
        else if (SkType == Skill.Skill_2)
        {
            Console.Clear();
            SkInfo.SkillType(Skill.Skill_2);
            myDmg = ((Status.Att + Randint) * SkInfo.SkillDamage);
            Randint = Rand.Next(-3, 3);
            Status.Hp += myDmg;                   // 회복
            Console.WriteLine($"{SkInfo.SkillName} 사용..{myDmg}만큼 회복..!! \n {Status.Hp} 이 되었다");
        }
    }


}