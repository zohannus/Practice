using System;

public enum Skill
{
    Skill_0 = 0,
    Skill_1,
    Skill_2,
    Skill_3
}
class Skill_Info
{
    public string SkillName;
    public string SkillInfo;
    public Skill SkiType = Skill.Skill_0;
    public float SkillDamage;
    public float SkillMana;

    public void SkillType(Skill SkType)
    {
        SkiType = SkType;
        if (SkType == Skill.Skill_0)
        {
            SkillName = "기본 공격";
            SkillDamage = 0.5f;
            SkillInfo = $"상대를 공격해{SkillDamage*100}%의 피해를 입힙니다.";
            SkillMana = 0;
        }
        else if(SkType == Skill.Skill_1)
        {
            SkillName = "강타";
            SkillDamage = 1.0f;
            SkillInfo = $"상대를 강하게 공격해{SkillDamage*100}%의 피해를 입힙니다.";
            SkillMana = 1;
        }
        else if (SkType == Skill.Skill_2)
        {
            SkillName = "회복";
            SkillDamage = 0.2f;
            SkillInfo = $"{SkillDamage*100}%만큼 회복합니다.";
            SkillMana = 2;
        }
        else if (SkType == Skill.Skill_3)
        {
            SkillName = "무적";
            SkillInfo = $"다음턴 동안 무적이 됩니다.";
            SkillMana = 1;
        }
    }
}

