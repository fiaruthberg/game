using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    class MissionTwo
    {
        public static void Run()
        {
            NightKing King = new NightKing();

            Console.Clear();
            Player.CheckHp();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Player.CenterText("****************************************************");
            Console.WriteLine();
            Player.CenterText("Mission behind the wall");
            Console.WriteLine();
            Player.CenterText("****************************************************");
            Console.ResetColor();
            Console.ReadKey();
            PrintSkull();
            
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Player.CenterText("You are now beyond the wall and the and you can feel the cold wind on your face. ");
            Player.CenterTextWithoutNewLine("You see the Night King with his icy sword. Do you want to attack him? (Y/N) ");
            if (Console.ReadLine().ToLower() == "y")
            {
                FightTheKing();
            }
            else
            {
                Player.CenterText("The Night king sees you and you start running towords the woods");
                Player.CenterText("That was a bad choice you coward! The King catches you and kills you on the spot");
                Player.HealthOfPlayer = 0;
                Console.ReadKey();
            }
        }   

        private static void FightTheKing()
        {
            Console.Clear();
            Console.WriteLine();
            Player.CenterText("You run towards the King with your " + Weapon.Name + " in your hand");
            Player.CenterText("You hit the King with your " + Weapon.Name);
            Console.Clear();
            while (Player.HealthOfPlayer > 0 && NightKing.MonsterHealth > 0)
            {
                Console.WriteLine();
                HitTheKing();
                Console.ReadKey();
                Console.Clear();
                if (NightKing.MonsterHealth > 0)
                {
                    Console.WriteLine();
                    KingHitMe();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (NightKing.MonsterHealth > 0)
            {
                Console.Clear();
                Console.WriteLine();
                Player.CenterText("You lost against the Night King! Now the white walkers will take over the world!!!!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Player.CenterText("You beat the King!! Thank to you " + Player.NameOfPlayer + ", we can live a little longer");
            }
        }

        private static void KingHitMe()
        {
            int hit = StartGame.RandomNumber(NightKing.LowestMonsterDmg, NightKing.HighestMonsterDmg);
            if (hit < 3)
            {
                Player.CenterText("The King almost missed and only did " + hit + " damage to you");
            }
            else if (hit > 7)
            {
                Player.CenterText("The King did his super punch and did " + hit + " damage to you");
            }
            else if (hit == 0)
            {
                Player.CenterText("You avoided the punch from the King");
            }
            else
            {
                Player.CenterText("The King did " + hit + " damage to you");
            }
            Console.WriteLine();
            Player.HealthOfPlayer = Player.HealthOfPlayer - hit;
            Player.CenterText("You have " + Player.HealthOfPlayer + " hp left");
        }

        private static void HitTheKing()
        {
            int hit = StartGame.RandomNumber(Weapon.LowestDmg, Weapon.HighestDmg);
            if (hit < 3)
            {
                Player.CenterText("You almost missed and only did " + hit + " damage on the King");
            }
            else if (hit > 7)
            {
                Player.CenterText("SUUUUUUPER PUNCH! You did " + hit + " damage on the King");
            }
            else if (hit == 0)
            {
                Player.CenterText("You missed the King with your sword");
            }
            else
            {
                Player.CenterText("You did " + hit + " damage on the King");
            }
            NightKing.MonsterHealth = NightKing.MonsterHealth - hit;
            Console.WriteLine();
            Player.CenterText("The King now has " + NightKing.MonsterHealth + " hp left");

        }
        private static void PrintSkull()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Player.CenterText(@"   .o oOOOOOOOo                                            OOOo     ");
            Player.CenterText(@"   Ob.OOOOOOOo OOOo.      oOOo.                      .adOOOOOOO     ");
            Player.CenterText(@"   OboO''''''''''''.OOo. .oOOOOOo.OOOo.oOOOOOo..''''''''''OO        ");
            Player.CenterText(@"   OOP.oOOOOOOOOOOO 'POOOOOOOOOOOo.   `'OOOOOOOOOP,OOOOOOOOOOOB'    ");
            Player.CenterText(@"   `O'OOOO'     `OOOOo'OOOOOOOOOOO` .adOOOOOOOOO'oOOO'    `OOOOo    ");
            Player.CenterText(@"   .OOOO'            `OOOOOOOOOOOOOOOOOOOOOOOOOO'            `OO    ");
            Player.CenterText(@"   OOOOO                 ''OOOOOOOOOOOOOOOO'`                oOO    ");
            Player.CenterText(@"  oOOOOOba.                .adOOOOOOOOOOba.adOOOOo.                 ");
            Player.CenterText(@" oOOOOOOOOOOOOOba.    .adOOOOOOOOOO@^ OOOOOOOba.     .adOOOOOOOOOOOO");
            Player.CenterText(@"OOOOOOOOOOOOOOOOO.OOOOOOOOOOOOOO'`  ''OOOOOOOOOOOOO.OOOOOOOOOOOOOO  ");
            Player.CenterText(@"'OOOO'       'YOoOOOOMOIONODOO'`  .   ''OOROAOPOEOOOoOY'     'OOO'  ");
            Player.CenterText(@"   Y           'OOOOOOOOOOOOOO: .oOOo. :OOOOOOOOOOO?'         :`    ");
            Player.CenterText(@"   :            .oO % OOOOOOOOOOo.OOOOOO.oOOOOOOOOOOOO?.            ");
            Player.CenterText(@"   .oOOP' % OOOOOOOOoOOOOOOO ? oOOOOO ? OOOO'OOo                    ");
            Player.CenterText(@"                '%o  OOOO' % OOOO % '%OOOOO'OOOOOO'OOO':            ");
            Player.CenterText(@"                     `$'  `OOOO' `O'Y ' `OOOO'  o.                  ");
            Player.CenterText(@"   .                  .OP'          : o.                            ");
            Player.CenterText(@"                             :                                      ");
            Player.CenterText(@"                             .                                      ");
            Player.CenterText(@"                      )                          )                  ");
            Player.CenterText(@"  *   )   )        ( /(             )    )    ( /(                  ");
            Player.CenterText(@"` )  /(( /(   (    )\())(  (  (  ( /( ( /(    )\())(        (  (    ");
            Player.CenterText(@" ( )(_))\()) ))\  ((_)\ )\ )\))( )\()))\()) |((_)\ )\  (    )\))(   ");
            Player.CenterText(@"(_(_()|(_)\ /((_)  _((_|(_|(_))\((_)\(_))/  |_ ((_|(_) )\ )((_))\   ");
            Player.CenterText(@"|_   _| |(_|_))   | \| |(_)(()(_) |(_) |_   | |/ / (_)_(_/( (()(_)  ");
            Player.CenterText(@"  | | | ' \/ -_)  | .` || / _` || ' \|  _|    ' <  | | ' \)) _` |   ");
            Player.CenterText(@"  |_| |_||_\___|  |_|\_||_\__, ||_||_|\__|   _|\_\ |_|_||_|\__, |   ");
            Player.CenterText(@"                          |___/                            |___/    ");
            Player.CenterText(@"                                                                    ");
            Console.ResetColor();
        }
    }
}
