using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    class Weapon
    {
        public static string Name { get; set; }
        public static int LowestDmg { get; set; }
        public static  int HighestDmg { get; set; }

        public static void ChooseWeapon()
        {
            while (true)
            {
                Console.WriteLine();
                Player.CenterTextWithoutNewLine("What weapon do you wanna choose? You get to choose between Axe and Sword: ");
                string playerChooseWeapon = Console.ReadLine();

                if (playerChooseWeapon.ToUpper() == "AXE")
                {
                    Axe axe = new Axe();
                    break;
                }
                else if (playerChooseWeapon.ToUpper() == "SWORD")
                {
                    Sword sword = new Sword();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Player.CenterTextWithoutNewLine("You will need a weapon " + Player.NameOfPlayer);
                    Console.ReadKey();
                }
            }
        }
    }

    class Axe : Weapon
    {
        public Axe()
        {
            Name = "Axe";
            LowestDmg = 3;
            HighestDmg = 8;
        }
    }
    class Sword : Weapon
    {
        public Sword()
        {
            Name = "Sword";
            LowestDmg = 4;
            HighestDmg = 7;
        }
    }
    class TwoHandedSword : Weapon
    {
        public TwoHandedSword()
        {
            Name = "TwoHandedSword";
            LowestDmg = 0;
            HighestDmg = 10;
        }
    }
    class Mace : Weapon
    {
        public Mace()
        {
            Name = "Mace";
            LowestDmg = 1;
            HighestDmg = 9;
        }
    }
}
