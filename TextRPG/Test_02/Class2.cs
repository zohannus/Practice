using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Class2
{
    public struct Monster_Struct
    {
        public string name;
        public int hp;
        public int att;
        public int speed;
        public void GetMonsterInfo()
        {
            Console.WriteLine($"기본 -- 이름 : {name} , 체력 : {hp}, 공격력 : {att}, 스피드 : {speed}");
        }
    }
    public void Start()
    {
        Monster_Struct monster1;
        monster1.name = "Slime";
        monster1.hp = 10;
        monster1.att = 1;
        monster1.speed = 5;

        Monster_Struct monster2 = monster1;
        monster2.name = "Wolf11";
        monster2.hp = 20;
        monster1.GetMonsterInfo();
        monster2.GetMonsterInfo();



        Monster_Class BossMonster = new Monster_Class();
        BossMonster.name = "shibal";
        BossMonster.hp = 1000;
        BossMonster.att = 50;
        BossMonster.speed = 5;

        Monster_Class BossMonster1 = BossMonster;
        BossMonster1.name = "yahoo";
        BossMonster1.hp = 2000;
        BossMonster1.att = BossMonster.att + 5;
        BossMonster1.speed = 5;
        BossMonster.GetMonsterInfo();
        BossMonster1.GetMonsterInfo();
    }

    public class Monster_Class
    {
        public string name;
        public int hp;
        public int att;
        public int speed;
        public void GetMonsterInfo()
        {
            Console.WriteLine($"기본 -- 이름 : {name} , 체력 : {hp}, 공격력 : {att}, 스피드 : {speed}");
        }
    }


}

