using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
   public class EndGame
    {
        
        public static bool ThankPlayerForPlaying()
        {
            if (Player.HealthOfPlayer >0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Player.CenterText(Player.NameOfPlayer + ", you saved the village from a disaster!");
                Player.CenterText("You completed the game!!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Player.CenterText("Send us some cash if you liked the game and want to play some more");
                
            }
            else if (Player.HealthOfPlayer <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Player.CenterText("You failed the mission " + Player.NameOfPlayer + ". Please do better next time!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Player.CenterText("Send us some cash if you liked the game and want to play some more");
                Player.CenterText(@"         _.--._             ");
                Player.CenterText(@"         \ ** /             ");
                Player.CenterText(@"          (<>)              ");
                Player.CenterText(@"   .      )  (       .      ");
                Player.CenterText(@"  )\_.._ / /\ \_.._ /(      ");
                Player.CenterText(@"   (*_ <> _  _<> _*)        ");
                Player.CenterText(@"  ) / '' \ \/ / '' \(       ");
                Player.CenterText(@"   '      )  (      '       ");
                Player.CenterText(@"           ()               ");
                Player.CenterText(@"           )(               ");
                Player.CenterText(@"          (<>)              ");
                Player.CenterText(@"         / ** \             ");
                Player.CenterText(@"        /.-..-.\            ");
            }
            Console.WriteLine();
            Player.CenterTextWithoutNewLine("Do you want to play again? (Y/N) ");
            string startOverOrNot = Console.ReadLine().ToLower();
            if (startOverOrNot == "y")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
