using System;
using System.Collections.Generic;
using static System.Console;

namespace EduProgGame_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntroScreen
            IntroScreen.gameIntro();
            IntroScreen.setPlayerName();
            IntroScreen.lvlComplete();

            //HelloWorld(lvl1)
            Lvl1.helloWorld();
            Lvl1.RandLootQ1();


            //EndScreen
            EndScreen.endGame();
        }
    }
}
