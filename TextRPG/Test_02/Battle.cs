using System;

class battle
{
    int Turn = 0;
    const int PlayerTurn = 0;
    const int ComputerTurn = 1;

    // 플레이어 변수
    float Hp = 100;
    float Dmg = 10;
    float Amr = 1;

    // 몬스터 변수
    float Mon_Hp = 50;
    float Mon_Dmg = 20;
    float Mon_Amr = 1;
    float Randint;
    Random Rand = new Random();

    Skill_Info SkInfo = new Skill_Info();

    public void Start()
    {
          // 랜덤값 (숙련도)

        while(true)
        {
            int i = 0;
            Console.WriteLine("무엇을 할까?");
            for(i = 0; i < Enum.GetValues(typeof(Skill)).Length; i++)
            {
                SkInfo.SkillType((Skill)i);
                Console.WriteLine($"{i}.{SkInfo.SkillName}:{SkInfo.SkillInfo}");
            }
            Console.WriteLine($"{i}.도망가기");
            string chat = Console.ReadLine();
            int.TryParse(chat, out int SkillChoice);

            PlayerAtt((Skill)SkillChoice);
        }




        //while (Hp <= 0 || Mon_Hp == 0)    //몬스터나 내 체력이 0이 되면
        //{
        //    if (Turn == PlayerTurn)
        //    {
        //        Console.WriteLine("플레이어의 턴"); //닉네임 변수로 바꾸기
        //    }
        //    else if (Turn == ComputerTurn)
        //    {
        //        Console.WriteLine("컴퓨터의 턴"); //몬스터 변수로 바꾸기
        //    }
        //}
    }

    void BattleStart()
    {

    }
    void PlayerAtt(Skill SkType)
    {
        float myDmg = ((Dmg - Mon_Amr + Randint) * SkInfo.SkillDamage );
        if (SkType == Skill.Skill_0)
        {
            Console.Clear();
            SkInfo.SkillType(Skill.Skill_0);
            myDmg = ((Dmg - Mon_Amr + Randint) * SkInfo.SkillDamage);
            Randint = Rand.Next(-3, 3);
            Mon_Hp -= myDmg;                   // 플레이어의 데미지 : 10 에서 +- 5
            Console.WriteLine($"{SkInfo.SkillName} 사용..{myDmg}의 타격..!! \n 적의 체력 :{Mon_Hp}");
        }
        else if (SkType == Skill.Skill_1)
        {
            Console.Clear();
            SkInfo.SkillType(Skill.Skill_1);
            myDmg = ((Dmg - Mon_Amr + Randint) * SkInfo.SkillDamage);
            Randint = Rand.Next(-3, 3);
            Mon_Hp -= myDmg;                   // 플레이어의 데미지 : 10 에서 +- 5
            Console.WriteLine($"{SkInfo.SkillName} 사용..{myDmg}의 타격..!! \n {Mon_Hp} 남았다.");
        }
        else if (SkType == Skill.Skill_2)
        {
            Console.Clear();
            SkInfo.SkillType(Skill.Skill_2);
            myDmg = ((Dmg + Randint) * SkInfo.SkillDamage);
            Randint = Rand.Next(-3, 3);
            Hp += myDmg;                   // 회복
            Console.WriteLine($"{SkInfo.SkillName} 사용..{myDmg}만큼 회복..!! \n {Hp} 이 되었다");
        }
    }

    void MonAtt(int M_Dmg, int P_Amr)
    {
        Hp = M_Dmg - P_Amr;
    }
}