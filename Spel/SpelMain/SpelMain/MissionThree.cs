using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpelMain
{
    class MissionThree
    {
        public static void Run()
        {
            MonsterCat cat = new MonsterCat();
            Console.Clear();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Player.CenterText("****************************************************");
            Console.WriteLine();
            Player.CenterText("Let's meet the cat!");
            Console.WriteLine();
            Player.CenterText("****************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();

            PrintCat();

            Console.ReadKey();

            Console.Clear();

            Player.CheckHp();

            Console.WriteLine();
            CenterLinePlusReadKey("You wake up in the middle of the woods. Everything is dark and quiet around you. ");
            CenterLinePlusReadKey("The air is thick and moist and it takes a while for you to realize where you are.");
            CenterLinePlusReadKey("You slowly get back on your feet to continue your journey.");

            Console.Clear();

            Console.WriteLine();
            CenterLinePlusReadKey("Suddenly you see a cute little cat in a glade, staring into the sky.");
            WriteInWhite("Would you like to cuddle the cat? (Y/N) ");

            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine();
                CenterLinePlusReadKey("You slowly move closer and kneel down while you reach out a hand.");
                CenterLinePlusReadKey("The cat turns around, but as soon as it notices you it instantly starts to transform...");
                Console.WriteLine();
                CenterLinePlusReadKey("OHNOO... IT'S A MONSTERCAT!");
                PrintMonsterCat();

                WriteInWhite("What do you do? [A]ttack or [R]un? ");

                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Clear();
                    Console.WriteLine();
                    FightTheCat();
                }
                else
                {
                    Console.WriteLine();
                    CenterLinePlusReadKey("Coward! The MonsterCat rips you apart and swallows you like candy");
                    Player.HealthOfPlayer = 0;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                CenterLinePlusReadKey("You don't have time to cuddle any cats right now. You have to get back to the village before the sunrise!");
                CenterLinePlusReadKey("As you are about to start walking, the cat notices you and instantly starts to transform...");
                Console.WriteLine();
                CenterLinePlusReadKey("... INTO A MONSTERCAT!");
                PrintMonsterCat();
                Console.Clear();


                Console.WriteLine();
                CenterLinePlusReadKey("You start to run, but the enormous feline hunts you down and stops right in front of you");
                WriteInWhite("What do you do? [P]lay dead or [A]ttack? ");

                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Clear();
                    FightTheCat();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Player.CenterText("Coward! The MonsterCat rips you apart and swallows you like candy");
                    Player.HealthOfPlayer = 0;
                }

                Console.ReadKey();
            }
        }

        private static void CenterLinePlusReadKey(string s)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + s.Length / 2) + "}", s);
            Console.ReadKey();
        }

        private static void WriteInWhite(string s)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0," + ((Console.WindowWidth / 2) + s.Length / 2) + "}", s);
            Console.ResetColor();
        }

        private static void PrintMonsterCat()
        {
            Player.CenterText(@"                    ;,_            ,                                       ");
            Player.CenterText(@"                  _uP~'b          d'u,                                     ");
            Player.CenterText(@"                 dP'   'b       ,d'  'o                                    ");
            Player.CenterText(@"                d'    , `b     d''    'b                                   ");
            Player.CenterText(@"               l] [    ' `l,  d'       lb                                  ");
            Player.CenterText(@"               Ol ?     '  'b`'=uoqo,_  'l                                 ");
            Player.CenterText(@"             , dBb 'b        'b,    `'~~TObup,_                            ");
            Player.CenterText(@"           , d' (db.`'         ''     'tbc,_ `~'Yuu, _                     ");
            Player.CenterText(@"         .d' l`T'  '=                      ~     `''Yu,                    ");
            Player.CenterText(@"       , dO` gP,                           `u, b, _  'b7                   ");
            Player.CenterText(@"      d?' ,d' l,                           `'b,_ `~b  '1                   ");
            Player.CenterText(@"    ,8i' dl   `l                 ,ggQOV',dbgq,._'  `l  lb                  ");
            Player.CenterText(@"   .df' (O,    '             ,ggQY'~  , @@@@@d'bd~  `b '1                  ");
            Player.CenterText(@"  .df'   `'           -=@QgpOY''     (b  @@@@P db    `Lp'b,                ");
            Player.CenterText(@" .d(_               'ko ' = d_, Q`  , _  '  'b,                            ");
            Player.CenterText(@" Ql.         `'qo,._          'tQo, _`''bo ;tb,    `'b,                    ");
            Player.CenterText(@" qQ | L           ~'QQQgggc,_.,dObc,opooO  `'~~';.   __,7,                 ");
            Player.CenterText(@" qp         t\io, _           `~'TOOggQV''''        _,dg,_ =PIQHib.        ");
            Player.CenterText(@" `qp        `Q['tQQQo,_                          ,pl{QOP''   7AFR`         ");
            Player.CenterText(@"   `         `tb  '''tQQQg,_             p' 'b   `       .;-.`Vl'          ");
            Player.CenterText(@"              'Yb      `'tQOOo, __    _, edb    ` .__ /`/ '|  |b;=;.__     ");
            Player.CenterText(@"                            `'tQQQOOOOP''`'\QV;qQObob'`-._`\_~~-._         ");
            Player.CenterText(@"                                 ''''._ /   | | oP'\_   ~\ ~\_~\           ");
            Player.CenterText(@"                                         `~'\ic,qggddOOP' |  | ~\   `\~-._ ");
            Player.CenterText(@"                                           , qP`'''|' | `\ `;   `\   `\    ");
            Player.CenterText(@"                                _        _, p'     |    |   `\`;    |    | ");
            Player.CenterText(@"                                'boo,._dP'       `\_  `\    `\|   `\   ;   ");
            Player.CenterText(@"                                  `'7tY~'            `\  `\    `|_   |     ");
            Player.CenterText(@"                                                     `~\  |                ");

            Console.ReadKey();

        }

        private static void PrintCat()
        {
            Player.CenterText(@"           |\____ /|                ");
            Player.CenterText(@"           )       (                ");
            Player.CenterText(@"          =\       /=               ");
            Player.CenterText(@"            )     (                 ");
            Player.CenterText(@"           /       \                ");
            Player.CenterText(@"           |       |                ");
            Player.CenterText(@"          /         \               ");
            Player.CenterText(@"          \         /               ");
            Player.CenterText(@"           \__   __/                ");
            Player.CenterText(@"             (  (                   ");
            Player.CenterText(@"              ) )                   ");
            Player.CenterText(@"             ( (                    ");
            Player.CenterText(@"             )_)                    ");
            Player.CenterText(@" _____ _            _____       _   ");
            Player.CenterText(@"|_   _| |          /  __ \     | |  ");
            Player.CenterText(@"  | | | |__   ___  | /  \/ __ _| |_ ");
            Player.CenterText(@"  | | | '_ \ / _ \ | |    / _` | __|");
            Player.CenterText(@"  | | | | | |  __/ | \__/\ (_| | |_ ");
            Player.CenterText(@"  \_/ |_| |_|\___|  \____/\__,_|\__|");
            Player.CenterText(@"                                    ");
            Player.CenterText(@"                                    ");
        }

        private static void FightTheCat()
        {
            Console.WriteLine();
            CenterLinePlusReadKey($"You run towards the MonsterCat with your { Weapon.Name} in your hand");
            CenterLinePlusReadKey($"You raise your { Weapon.Name }, and it slashes the tail of the beast.");
            Console.WriteLine();
            Console.Clear();
            while (Player.HealthOfPlayer > 0 && MonsterCat.MonsterHealth > 0)
            {
                MonsterCat.MonsterHealth = HitTheCat(MonsterCat.MonsterHealth);
                Console.Clear();
                if (MonsterCat.MonsterHealth > 0)
                {
                    CatHitMe();
                    Console.Clear();
                }

            }
            Console.Clear();
            if (MonsterCat.MonsterHealth > 0)
            {
                Console.WriteLine();
                Player.CenterText("You lost against the monstrous feline! Now the catastrophies will take over the world!!!!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Player.CenterText($"You beat the MonsterCat!! Thank to you {Player.NameOfPlayer}! The village is safe for a little longer all thanks to you.");
                Console.WriteLine();
            }
        }


        private static void CatHitMe()
        {
            int hit = StartGame.RandomNumber(MonsterCat.LowestMonsterDmg, MonsterCat.HighestMonsterDmg);
            Console.WriteLine();
            Player.CenterText($"The MonsterCat did { hit } damage to you");
            Player.HealthOfPlayer = Player.HealthOfPlayer - hit;
            Console.WriteLine();
            if (Player.HealthOfPlayer < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Player.CenterTextWithoutNewLine($"OHNOOO YOU'RE DEAD!");
                Console.ResetColor();

            }
            else
            {
                Player.CenterTextWithoutNewLine($"You have { Player.HealthOfPlayer } hp left");
            }
            Console.ReadKey();

        }

        private static int HitTheCat(int monsterCat)
        {
            int hit = StartGame.RandomNumber(Weapon.LowestDmg, Weapon.HighestDmg);
            if (hit < 3)
            {
                Console.WriteLine();
                Player.CenterText($"What are you doing?? You only did { hit } damage on the MonsterCat");
            }
            else if (hit > 7)
            {
                Console.WriteLine();
                Player.CenterText($"WHHHOOOOOAAAA!! You did { hit } damage on the MonsterCat");
            }
            else
            {
                Console.WriteLine();
                Player.CenterText($"You did { hit } damage on the Cat");
            }
            Console.WriteLine();
            int hpOnCat = monsterCat - hit;
            if (hpOnCat < 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Player.CenterTextWithoutNewLine($"THE CAT IS DEAD!!");
                Console.ResetColor();
            }
            else
            {
                Player.CenterTextWithoutNewLine($"The Cat now has { hpOnCat } hp left");
            }
            Console.ReadKey();
            return hpOnCat;
        }
    }
}
