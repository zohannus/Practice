using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class Monster
{
    public string Name { get; set; }
    public float Hp { get;  set; }
    public float Atk { get; set; }
    public float Amr { get; set; }
    public float Exp { get; set; }
    public float Spd { get; set; }
    public Monster(string name, float hp, float atk, float amr, float exp, float spd)
    {
        Name = name;
        Hp = hp;
        Atk = atk;
        Amr = amr;
        Exp = exp;
        Spd = spd;
    }

}

public class MonsterManager
{

    public List<Monster> mobList { get; set; }
    public float mobDamage = 0;
    public MonsterManager()
    {
        mobList = new List<Monster>()
            {//이름 / 체력 / 공격력 / 방어력 / 경험치 / 속도
                new Monster("슬라임", 30, 10, 0, 1, 1),
                new Monster("늑대", 20, 15, 0, 2, 1),
                new Monster("새끼용", 30, 10, 0, 5, 1),
                new Monster("하이에나", 40, 15, 1, 4, 1)
            };
    }

    public (string name, float resultDMG) MobNormalAttack(int mobChoice)
    {
        Random rand = new Random();
        int atkType = 0;
        string atkName = "";
        atkType = rand.Next(4);
        Monster monster = mobList[mobChoice];
        
        float dmgPlus = 0.0f;
        switch (atkType)
        {
            case 0:
                dmgPlus = 0.2f; atkName = "스친 공격";  break;
            case 1:
                dmgPlus = 0.7f; atkName = "정확한 공격"; break;
            case 2:
                dmgPlus = 1.0f; atkName = "치명타"; break;
            case 3:
                dmgPlus = 0.0f; atkName = "빗나감"; break;

               
        }
        mobDamage = (monster.Atk - CharacterStatus.Instance.Amr) * dmgPlus;
        return (atkName, mobDamage);
    }
}


