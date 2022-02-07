using System;
using System.Collections.Generic;
using static System.Console;

namespace EduProgGame_Text
{
    public static class IntroScreen
    {
        public static string playerName = "";
        public static List<string> CodeAbsorbed = new List<string>();
        public static List<string> LootWon = new List<string>();

        public static void gameIntro()
        {
            Console.Title = " ***Traversing the Universe***";
            WriteLine("------------------------------------------------------------------------------------------------------------------" +
                "\n Traversing the Universe" +
                "\n------------------------------------------------------------------------------------------------------------------" +
                "\n HELP HELP! Last night while writing a program Don fell asleep..." +
                "\n During the night Don's computer crashed sending dozens of lines of code out into the universe." +
                "\n " +
                "\n **My name is Main() " +
                "\n And I need YOUR help to locate all the missing snippets of code so we can reasemble the lost programs " +
                "\n before they are gone forever. " +
                "\n------------------------------------------------------------------------------------------------------------------" +
                "\n Please help me find my friends!!! " +
                "\n " +
                /*should give choice to help or not/ if yes game continues else statement about 
                 * if you change your mind I will be here etc./end screen*/
                "\n *Press the space bar to help Main() and begin the search*"); 
            WriteLine(" ");
            ReadKey();
            Clear();
        }

        public static void setPlayerName()
        {
            WriteLine("\n Oh, what a relief! Thank you! Thank you!" +
                "\n If we are going to be working together, what should I call you?" +
                "\n ");
            Write(" ");
            playerName = ReadLine();
            WriteLine("\n Thanks again, " + playerName + "! Your're a life saver!" +
                "\n Programming can be challenging but working together we can accomplish anything!");
            WriteLine("------------------------------------------------------------------------------------------------------------------");
        }

        public static void lvlComplete() 
        {
            WriteLine("\n *Before we get start, one thing to keep in mind... spelling is VERY important while traversing the universe." +
                "\n -- So don't forget! -- " +
                "\n Otherwise, we might never find all the snippets. " +
                "\n " +
                "\n **Let's begin!**" +
                "\n\n *Press the space bar to begin the search*"); 
            WriteLine(" ");
            ReadKey();
            Clear();
        }
    }
}
