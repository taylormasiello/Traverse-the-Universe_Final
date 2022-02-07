using System;
using System.Collections.Generic;
using static EduProgGame_Text.IntroScreen;
using static System.Console;

namespace EduProgGame_Text
{
    public static class EndScreen
    {
        public static void endGame()
        {
            Console.Title = "End of Demo!"; 

            WriteLine("Congrats on completing our demo! You found some surprising loot along the way: ");
            foreach (string item in LootWon)
            {
                WriteLine(item);
                WriteLine();
            }

            WriteLine("Main function was able to reabsorb the following code snippets thanks to your help: "); 
            foreach (string codeSnippet in CodeAbsorbed)
            {
                WriteLine(codeSnippet);
                WriteLine();
            }
            WriteLine("\nThanks for playin' our game! Made by Mel & Tay :)\n");

            //logic for switch, # of codeSnippets will trigger diff endings

        }

    }
}
