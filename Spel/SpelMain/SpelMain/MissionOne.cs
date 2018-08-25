using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    public class MissionOne
    {
        public static void Run()
        {
            Player.CheckHp();

            Console.WriteLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Player.CenterText("-----------------------------------------------------------");
            Player.CenterText("Dragon Mission");
            Player.CenterText("-----------------------------------------------------------");
            Console.ReadKey();
            Console.ResetColor();

            Console.Clear();
            Console.WriteLine();
            Player.CenterText("You're out wandering in the woods and trying to find the dragon..");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine();
            Player.CenterTextWithoutNewLine("You find 2 paths to choose between. Go up the [H]ills or deeper in to the [W]oods? ");

            while (true)
            {
                string pathChoice = Console.ReadLine();
                if (pathChoice.ToUpper() == "H")
                {
                    Hills();
                    break;
                }

                if (pathChoice.ToUpper() == "W")

                {
                    Woods();
                    break;
                }
                if (string.IsNullOrEmpty(pathChoice))
                {
                    Console.WriteLine();
                    Player.CenterTextWithoutNewLine("You need to choose a path to countiue.");
                }
            }
        }
        public static void Hills()
        {
            Console.Clear();
            Console.WriteLine();
            TwoHandSword();
            Player.CenterTextWithoutNewLine($"You walk up the hills and find a Two handed Sword. Do you wanna use it instead of your {Weapon.Name}? Y/N: ");
            string playerChangeWeapon = Console.ReadLine();
            Console.WriteLine();


            if (playerChangeWeapon.ToUpper() == "Y")
            {
                Weapon.Name = "Two Handed Sword";
                TwoHandedSword TwoHandedS = new TwoHandedSword();
                Player.CenterText($"You equiped the {Weapon.Name}.");
                Player.CenterText("You find nothing more in the hills so you decide to walk down the hill and take the other path..");
                Console.ReadKey();
                Woods();

            }
            if (playerChangeWeapon.ToUpper() == "N")
            {
                Console.WriteLine();
                Player.CenterText("You leave the weapon and decide to walk down the hill and go deeper into the forest instead ");
                Woods();

            }
        }


        public static void Woods()
        {
            Console.Clear();
            Console.WriteLine();
            Player.CenterText("You're now deep in the woods ");
            Console.WriteLine();
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine();
            Player.CenterText("You see a mysterious cave");
            Console.ReadKey();
            Player.CenterTextWithoutNewLine("Do you wanna go in to the cave? [Y]es / [N]o: ");
            string pathChoice = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();



            if (pathChoice.ToUpper() == "Y")

            {
                Console.WriteLine();
                Player.CenterText("You see the dragon sleeping in the cave ");
                Console.ReadKey();
                Console.WriteLine();

                FightAgainstTheDragon();

            }
            if (pathChoice.ToUpper() == "N")
            {
                Console.WriteLine();
                Player.CenterText("You walk away but hear something from the cave...");
                Console.WriteLine();
                Console.ReadKey();

                Player.CenterText("You turn around and see the dragon flying towards you!! ");
                Console.ReadKey();
                Player.CenterText("The dragon deals 5 damage to you cause you was not ready for the fight..");
                Player.HealthOfPlayer = Player.HealthOfPlayer - 5;
                Console.WriteLine();
                Console.ReadKey();

                Player.CenterText($"You got {Player.HealthOfPlayer} remaning");

                FightAgainstTheDragon();

            }
        }
        public static void FightAgainstTheDragon()
        {
            Dragon dragon = new Dragon();

            Console.Clear();
            PrintDragon();
            Console.ReadKey();

            while (Dragon.MonsterHealth > 0 && Player.HealthOfPlayer > 0)
            {

                int yourdmg = StartGame.RandomNumber(Weapon.LowestDmg, Weapon.HighestDmg);
                Dragon.MonsterHealth = Dragon.MonsterHealth - yourdmg;

                if (yourdmg == 0)
                {
                    Console.WriteLine();
                    Player.CenterText("You missed the attack..");
                }

                if (yourdmg >= 6)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Player.CenterText($"You got a critcial hit on the dragon with your {Weapon.Name} and dealt {yourdmg} damage");
                    Console.WriteLine();
                    Player.CenterText($"The dragon has {Dragon.MonsterHealth} health remaning");
                    Console.ReadKey();
                }

                if (yourdmg < 6 && yourdmg > 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Player.CenterText($"You dealt {yourdmg} damage to the dragon ");
                    Console.WriteLine();
                    Player.CenterText($"The dragon has {Dragon.MonsterHealth} health remaning");
                    Console.ReadKey();
                }

                if (Dragon.MonsterHealth <= 0)
                {
                    Console.WriteLine();
                    Player.CenterText("You managed to kill the dragon!!");
                    Console.ReadKey();
                    break;
                }

                int dragondmg = StartGame.RandomNumber(Dragon.LowestMonsterDmg, Dragon.HighestMonsterDmg);
                Player.HealthOfPlayer = Player.HealthOfPlayer - dragondmg;

                if (dragondmg >= 8)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Player.CenterText($"The dragon use he's fire breath against you and you take {dragondmg}");
                    Console.WriteLine();
                    Player.CenterText($"You got {Player.HealthOfPlayer} health remaning..");
                    Console.ReadKey();

                }

                if (dragondmg < 8 && dragondmg > 4)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Player.CenterText($"The dragon bites you and you take {dragondmg} damage");
                    Console.WriteLine();
                    Player.CenterText($"You got {Player.HealthOfPlayer} health remaning..");
                    Console.ReadKey();

                }

                if (dragondmg < 4 && dragondmg > 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Player.CenterText($"The dragon slashes you with he's claw and you take {dragondmg} damage");
                    Console.WriteLine();
                    Player.CenterText($"You got {Player.HealthOfPlayer} health remaning..");
                    Console.ReadKey();

                }

                if (dragondmg == 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Player.CenterText($"The dragon missed the attack!");
                    Console.WriteLine();
                    Player.CenterText($"You got {Player.HealthOfPlayer} health remaning..");
                    Console.ReadKey();
                }
            }
        }
        private static void PrintDragon()
        {
            Console.WriteLine();
            Player.CenterText(@"                                          _,,,.._       ,_                                       ");
            Player.CenterText(@"                                       .gMMMMMMMMMp,_    `\                                      ");
            Player.CenterText(@"                                    .dMMP'       ``^YMb..dP                                      ");
            Player.CenterText(@"                                   dMMP'                                                         ");
            Player.CenterText(@"                                   MMM:                                                          ");
            Player.CenterText(@"                                   YMMb.                                                         ");
            Player.CenterText(@"                                    YMMMb.                                                       ");
            Player.CenterText(@"                                     `YMM/|Mb.  ,__                                              ");
            Player.CenterText(@"                                  _,,-~`--..-~-'_,/`--,,,____                                    ");
            Player.CenterText(@"                              `\,_,/',_.-~_..-~/' ,/---~~~'''`\                                  ");
            Player.CenterText(@"                         _,_,,,\q\q/'    \,,-~'_,/`````-,7.                                      ");
            Player.CenterText(@"                        `@v@`\\,,,,__   \,,-~~'__/` ',,/MMMMb.                                   ");
            Player.CenterText(@"                         `--''_..-~~\   \,-~~""  `\_,/ `^YMMMMMb..                               ");
            Player.CenterText(@"                          ,|``-~~--./_,,_  _,,-~~'/_      `YMMMMMMMb.                            ");
            Player.CenterText(@"                        ,/  `\,_,,/`\    `\,___,,,/M/'      `YMMMMMMMb                           ");
            Player.CenterText(@"                                    ;  _,,/__...|MMM/         YMMMMMMMb                          ");
            Player.CenterText(@"                                     .' /'      dMMM\         !MMMMMMMMb                         ");
            Player.CenterText(@"                                  ,-'.-'""~~~--/M|M' \        !MMMMMMMMM                         ");
            Player.CenterText(@"                                ,/ .|...._____/MMM\   b       gMMMMMMMMM                         ");
            Player.CenterText(@"                             ,'/'\/          dMMP/'   M.     ,MMMMMMMMMP                         ");
            Player.CenterText(@"                            / `\;/~~~~----...MP'     ,MMb..,dMMMMMMMMM'                          ");
            Player.CenterText(@"                           / ,_  |          _/      dMMMMMMMMMMMMMMMMB                           ");
            Player.CenterText(@"                           \  |\,\,,,,___ _/    _,dMMMMMMMMMMMP'.emmmb,                          ");
            Player.CenterText(@"                            `.\  gY.     /      7MMMMMMMMMMP'..emmMMMMM                          ");
            Player.CenterText(@"                               .dMMMb,-..|       `.~~'''```|dMMMMP'MMP'                          ");
            Player.CenterText(@"                              .MMMMP^'''/ .7 ,  _  \,---~''`^YMMP'MM;                            ");
            Player.CenterText(@"                            _dMMMP'   ,' / | |\ \\  }          PM^M^b                            ");
            Player.CenterText(@"                         _,' _,  \_.._`./  } ; \ \``'      __,'_` _  `._                         ");
            Player.CenterText(@"                     ,-~/'./'| 7`,,__,}`   ``   ``        // _/`| 7``-._`}                       ");
            Player.CenterText(@"                    |_,}__{  {,/'   ``                    `\{_  {,/'   ``                        ");
            Player.CenterText(@"                    ``  ```   ``                            ``   ``                              ");
            Player.CenterText(@"   _________.__                   __  .__                 .___                                   ");
            Player.CenterText(@"  /   _____/|  | _____  ___.__. _/  |_|  |__   ____     __| _/___________    ____   ____   ____  ");
            Player.CenterText(@"  \_____  \ |  | \__  \<   |  | \   __\  |  \_/ __ \   / __ |\_  __ \__  \  / ___\ /  _ \ /    \ ");
            Player.CenterText(@"  /        \|  |__/ __ \\___  |  |  | |   Y  \  ___/  / /_/ | |  | \// __ \/ /_/  >  <_> )   |  \");
            Player.CenterText(@" /_______  /|____(____  / ____|  |__| |___|  /\___  > \____ | |__|  (____  |___  / \____/|___|  /");
            Player.CenterText(@"         \/           \/\/                 \/     \/       \/            \/_____/             \/ ");
            Player.CenterText(@"                                                                                                 ");
        }

        public static void TwoHandSword()
        {
            Player.CenterText(@"              />                                                           ");
            Player.CenterText(@" ()          //----------------------------------------------------------\ ");
            Player.CenterText(@"(*)OXOXOXOXO(*>                                                           \");
            Player.CenterText(@" ()          \\-----------------------------------------------------------/");
            Player.CenterText(@"              \\>                                                          ");
        }
    }
}
