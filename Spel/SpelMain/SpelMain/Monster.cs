using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    class Monster
    {
        public static int MonsterHealth { get; set; }
        public static string NameOfMonster { get; set; }
        public static int LowestMonsterDmg { get; set; }
        public static int HighestMonsterDmg { get; set; }
    }

    class Dragon : Monster
    {
        public Dragon()
        {
            MonsterHealth = 15;
            NameOfMonster = "Dragon";
            LowestMonsterDmg = 0;
            HighestMonsterDmg = 5;
        }
    }
    class MonsterCat : Monster
    {
        public MonsterCat()
        {
            MonsterHealth = 15;
            NameOfMonster = "MonsterCat";
            LowestMonsterDmg = 1;
            HighestMonsterDmg = 6;

        }
    }
    class NightKing : Monster
    {
        public NightKing()
        {
            MonsterHealth = 15;
            NameOfMonster = "NightKing";
            LowestMonsterDmg = 2;
            HighestMonsterDmg = 7;
        }
    }
}
