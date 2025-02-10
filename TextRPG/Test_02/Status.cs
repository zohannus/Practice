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


public class CharacterStatus
{
    public string CharacterName = "";
    public float Hp = 100;
    public float Mana = 20;
    public float Amr = 1;
    public int Money = 100000;
    public int EquipCode = 0;
    public float Damage = 10;
    public int Locate = 0;
}