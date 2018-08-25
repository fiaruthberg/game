using System;

namespace SpelMain
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCoolText();
            
            while(true)
            {
                Player.Run();
                Console.Clear();
                StartGame.Run();
                Console.Clear();
                bool reRun = EndGame.ThankPlayerForPlaying();
                if (reRun == false)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine();
                    
            }


        }

        private static void PrintCoolText()
        {
            Player.CenterText(@"                                                                              ");
            Player.CenterText(@" /$$      /$$           /$$                                                   ");
            Player.CenterText(@"| $$  /$ | $$          | $$                                                   ");
            Player.CenterText(@"| $$ /$$$| $$  /$$$$$$ | $$  /$$$$$$$  /$$$$$$  /$$$$$$/$$$$   /$$$$$$        ");
            Player.CenterText(@"| $$/$$ $$ $$ /$$__  $$| $$ /$$_____/ /$$__  $$| $$_  $$_  $$ /$$__  $$       ");
            Player.CenterText(@"| $$$$_  $$$$| $$$$$$$$| $$| $$      | $$  \ $$| $$ \ $$ \ $$| $$$$$$$$       ");
            Player.CenterText(@"| $$$/ \  $$$| $$_____/| $$| $$      | $$  | $$| $$ | $$ | $$| $$_____/       ");
            Player.CenterText(@"| $$/   \  $$|  $$$$$$$| $$|  $$$$$$$|  $$$$$$/| $$ | $$ | $$|  $$$$$$$       ");
            Player.CenterText(@"|__/     \__/ \_______/|__/ \_______/ \______/ |__/ |__/ |__/ \_______/       ");
            Player.CenterText(@"                                                                              ");
            Player.CenterText(@"                                                                              ");
            Player.CenterText(@"                                                                              ");
            Console.ReadLine();
        }
    }
}
