using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

struct MonsterList
{
    public float Hp;
    public string Name;
    public float Atk;
    public float Amr;
    public int Exp;
    public int Spd;
}
class Monster
{
    public MonsterList[] Monst = new MonsterList[3];

    public Monster()
    {
        Monst[0].Hp = 30;
        Monst[0].Name = "슬라임";
        Monst[0].Atk = 10;
        Monst[0].Amr = 0;
        Monst[0].Spd = 1;
        Monst[0].Exp = 1;

        Monst[1].Hp = 20;
        Monst[1].Name = "늑대";
        Monst[1].Atk = 10;
        Monst[1].Amr = 0;
        Monst[1].Spd = 5;
        Monst[1].Exp = 1;

        Monst[2].Hp = 30;
        Monst[2].Name = "새끼용";
        Monst[2].Atk = 10;
        Monst[2].Amr = 0;
        Monst[2].Spd = 3;
        Monst[2].Exp = 1;
    }

    float MonHp;
    float MonName;
    float MonAtk;
    float MonAmr;
    float MonSpd;
    float MonExp;
    public void FieldMonster()
    {
        int MonstAmount = 0;
        Monster[] FieldMonst = new Monster[1];
        FieldMonst[0] = Monst[0];
    }

}

