using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AdventuresOfRaymond
{
    class Program
    {
        static void Main(string[] args)
        {
            //init
            string choiceTxt = "";
            bool choiceEnabled = true;
            //Intro
            Console.WriteLine("Once upon a time, there was a guy named Raymond, but some called him RD.");
            Console.WriteLine("");
            Console.WriteLine("Raymond was in Mrs. Brown's class when he was snooping through Derek's programming" +
                " projects and upon running one of them, accidentally opened up a secret trapdoor below Mrs. Brown's computer.");
            Console.WriteLine("");
            Console.WriteLine("Should Raymond enter?");
            while (choiceEnabled == true)
            {
                choiceTxt = Console.ReadLine();
                if (choiceTxt == "Yes")
                {
                    Console.WriteLine("Raymond went through the trapdoor.");
                    choiceEnabled = false;
                    Console.WriteLine("");
                    trapdoorScene();
                }
                else if (choiceTxt == "No")
                {
                    Console.WriteLine("Raymond had no sense of adventure.");
                    choiceEnabled = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            showCredits();
            Console.ReadLine();
        }

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        static void trapdoorScene()
        {
            string choiceTxt = "";
            bool choiceEnabled = true;

            Console.WriteLine("Raymond climbed down a ladder under the trapdoor and found himself standing on the edge of a wide pit" +
                " with a rope bridge going across it.");
            Console.WriteLine("Upon steping on the bridge, the wooden planks began to crack.");
            Console.WriteLine("How should Raymond cross the bridge? Slowly or Quickly?");
            while (choiceEnabled == true)
            {
                choiceTxt = Console.ReadLine();
                if (choiceTxt == "Quickly")
                {
                    Console.WriteLine("Raymond ran across the bridge, causing it to fall behind him. But, he made it safely.");
                    choiceEnabled = false;
                    Console.WriteLine("");
                    treasureScene();
                }
                else if (choiceTxt == "Slowly")
                {
                    Console.WriteLine("Because Raymond moved to slowly, the constant pressure on the bridge caused it to collapse, taking " +
                        "Raymond with it.");
                    choiceEnabled = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        static void treasureScene()
        {
            string choiceTxt = "";
            bool choiceEnabled = true;

            Console.WriteLine("After making it across the pit, Raymond found a room with a treasure chest. However the chest has" +
                " two buttons, one labeled \"Do/While\" and the other \"While\" ");
            Console.WriteLine("Above the chest was a sign with a riddle.");
            Console.WriteLine("\"To access the treasure of DHHS, you must use knowlege gained from coding." +
                " How does one create a loop that always runs once?\"");
            Console.WriteLine("Which button should Raymond push?");
            while (choiceEnabled == true)
            {
                choiceTxt = Console.ReadLine();
                if (choiceTxt == "Do/While")
                {
                    Console.WriteLine("Raymond opened the treasure to discover a diamond studded Thor hammer worth $$$$!!");
                    choiceEnabled = false;
                    Console.WriteLine("Awsome job! You did it!");
                }
                else if (choiceTxt == "While")
                {
                    Console.WriteLine("A boulder drops on Raymond, sad day.");
                    choiceEnabled = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        static void showCredits()
        {
            string choiceTxt = "";
            Console.WriteLine("");
            Console.WriteLine("Would you like to see the credits?");
            choiceTxt = Console.ReadLine();
            if (choiceTxt == "Yes")
            {
                Console.WriteLine("");
                Console.WriteLine("Programmed and written by:");
                Console.WriteLine(" ___________________________");
                Console.WriteLine(" |   ____________________   |");
                Console.WriteLine(" |  |   ___        ___   |  |");
                Console.WriteLine(" |  |--|_O_|------|_O_|--|  |");
                Console.WriteLine(" |  |         __         |  |");
                Console.WriteLine(@" |  |       \____        |  |");
                Console.WriteLine(" |  |                    |  |");
                Console.WriteLine(" |  |_________   ________|  |");
                Console.WriteLine(@" |__|________|\_/|_______|__|");
                Console.WriteLine(@"      |___|__|/ \|__|___|    ");
                Console.WriteLine(@"     /   Derek    ""Jex""  \   ");
                Console.WriteLine(@"    /       Sneddon       \  ");
                Console.WriteLine(@"    -----------------------  ");
            }
        }
    }
}
