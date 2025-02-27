using System;

namespace Test_02
{
    public enum Skill
    {
        Skill_0 = 0,
        Skill_1,
        Skill_2,
        Skill_3
    }
    class Skill_Info : IManager
    {
        public string SkillName;
        public string SkillInfo;
        public float SkillDamage;
        public float SkillMana;
        public Skill SkiType = Skill.Skill_0;

        float Randint;

        public void SkillType(Skill SkType)
        {
            SkiType = SkType;
            if (SkType == Skill.Skill_0)
            {
                SkillName = "기본 공격";
                SkillDamage = 0.5f;
                SkillInfo = $"상대를 공격해{SkillDamage * 100}%의 피해를 입힙니다.";
                SkillMana = 0;
            }
            else if (SkType == Skill.Skill_1)
            {
                SkillName = "강타";
                SkillDamage = 1.0f;
                SkillInfo = $"상대를 강하게 공격해{SkillDamage * 100}%의 피해를 입힙니다.";
                SkillMana = 1;
            }
            else if (SkType == Skill.Skill_2)
            {
                SkillName = "회복";
                SkillDamage = 0.2f;
                SkillInfo = $"{SkillDamage * 100}%만큼 회복합니다.";
                SkillMana = 2;
            }
            else if (SkType == Skill.Skill_3)
            {
                SkillName = "무적";
                SkillInfo = $"다음턴 동안 무적이 됩니다.";
                SkillMana = 1;
            }
        }

        public void Initialize()
        {

        }

        public void Update()
        {

        }
        public void Release()
        {

        }
        public void PlayerAtk(Skill SkType, Monster mob)
        {
            Random rand = new Random();
            float myDmg = ((CharacterStatus.Instance.Atk - mob.Amr + Randint) * SkillDamage);
            if (SkType == Skill.Skill_0)
            {
                Console.Clear();
                SkillType(Skill.Skill_0);
                myDmg = ((CharacterStatus.Instance.Atk - mob.Amr + Randint) * SkillDamage);
                Randint = rand.Next(-3, 3);
                mob.Hp -= myDmg;                   // 플레이어의 데미지 : 10 에서 +- 5
                Console.WriteLine($"{SkillName} 사용..{myDmg}의 타격..!! \n 적의 체력 :{mob.Hp}");
            }
            else if (SkType == Skill.Skill_1)
            {
                Console.Clear();
                SkillType(Skill.Skill_1);
                myDmg = ((CharacterStatus.Instance.Atk - mob.Amr + Randint) * SkillDamage);
                Randint = rand.Next(-3, 3);
                mob.Hp -= myDmg;                   // 플레이어의 데미지 : 10 에서 +- 5
                Console.WriteLine($"{SkillName} 사용..{myDmg}의 타격..!! \n {mob.Hp} 남았다.");
            }
            else if (SkType == Skill.Skill_2)
            {
                Console.Clear();
                SkillType(Skill.Skill_2);
                myDmg = CharacterStatus.Instance.Hp * 0.2f;
                CharacterStatus.Instance.Hp += myDmg;                   // 회복
                Console.WriteLine($"{SkillName} 사용..{myDmg}만큼 회복..!! \n {CharacterStatus.Instance.Hp} 이 되었다");
            }
        }
    }

}