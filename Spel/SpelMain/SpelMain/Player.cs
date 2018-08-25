using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    static public class Player
    {
        static public string NameOfPlayer { get; set; }
        static public int HealthOfPlayer = 25;

        public static void Run()
        {
            ChooseName();
            Console.Clear();
            Weapon.ChooseWeapon();
        }

        public static void ChooseName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenterText("****************************************************");
            Console.WriteLine();
            CenterText("NEW PLAYER");
            Console.WriteLine();
            CenterText("****************************************************");
            Console.WriteLine();
            Console.ResetColor();

            CenterTextWithoutNewLine("Enter your name: ");
            string PlayerChooseName = Console.ReadLine();
            if (PlayerChooseName == "Christoffer")
            {
                Console.WriteLine("Christoffer, du får inte lira det här spelet!");
                NameOfPlayer = "YOU SHALL NOT PASS!";
                Console.ReadKey();
            }
            else
            {
                NameOfPlayer = (PlayerChooseName);
            }

        }

        public static void CenterTextWithoutNewLine(string s)
        {
            Console.Write("{0," + ((Console.WindowWidth / 2) + s.Length / 2) + "}", s);
        }

        public static void CenterText(string s)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + s.Length / 2) + "}", s);
        }

        public static void CheckHp()
        {
            if (HealthOfPlayer < 16)
            {
                HealthOfPlayer = HealthOfPlayer + 10;
            }
            else
            {
                HealthOfPlayer = 25;
            }
        }
    }
}
