using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    class StartGame
    {
        public static void Run()
        {
            GreetPlayer();
            ChooseMission();
        }

        private static void GreetPlayer()
        {
            Console.Clear();
            Console.WriteLine();
            Player.CenterText("Hello there " + Player.NameOfPlayer + "! That looks like a nice " + Weapon.Name + " you got there");
            Console.ReadKey();
        }

        public static void ChooseMission()
        {
            int testMission = 3;
            Player.CenterTextWithoutNewLine("Do you want to help me slay the big dragon? (Y/N) ");
            if (Console.ReadLine().ToLower() == "y")
            {
                MissionOne.Run();
                testMission--;
                if (Player.HealthOfPlayer > 0)
                {
                    ThankYouMessage();
                    MissionTwo.Run();
                    testMission--;
                    if (Player.HealthOfPlayer > 0)
                    {
                        ThankYouMessage();
                        MissionThree.Run();
                        testMission--;
                    }
                }
            }
            else
            {
                Player.CenterTextWithoutNewLine("The dragon will go to bed anyway.. But please help me attack The Night's King? (Y/N) ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    MissionTwo.Run();
                    testMission--;
                    if (Player.HealthOfPlayer > 0)
                    {
                        ThankYouMessage();
                        MissionThree.Run();
                        testMission--;
                        if (Player.HealthOfPlayer > 0)
                        {
                            ThankYouMessage();
                            MissionOne.Run();
                            testMission--;
                        }
                    }
                }
                else
                {
                    Player.CenterTextWithoutNewLine("You coward! You can go to the cat then! (Y/N) ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        MissionThree.Run();
                        testMission--;
                        if (Player.HealthOfPlayer > 0)
                        {
                            ThankYouMessage();
                            MissionTwo.Run();
                            testMission--;
                            if (Player.HealthOfPlayer > 0)
                            {
                                ThankYouMessage();
                                MissionOne.Run();
                                testMission--;
                            }
                        }
                    }
                    else
                        Player.CenterText("You don't have a choice " + Player.NameOfPlayer + ". You are going to the dragon NOW!");
                    MissionOne.Run();
                }
            }
            Console.Clear();

        }

        public static int RandomNumber(int lowest, int highest)
        {
            Random random = new Random();
            int randomNumber = random.Next(lowest, highest);
            return randomNumber;
        }

        public static void ThankYouMessage()
        {
            Console.Clear();
            Console.WriteLine();
            Player.CenterText("Thank you " + Player.NameOfPlayer + ". You really saved the day! Please help us with our next quest");
            Console.ReadKey();
        }

    }
}
