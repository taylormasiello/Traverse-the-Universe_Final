using System;
using static EduProgGame_Text.IntroScreen;
using static System.Console;

namespace EduProgGame_Text
{
    public static class Lvl1
    {
        
        static string[] encounter1 = {
        //7 element string[] of dialog for encounter1

        /* insert player name*/
        //"1.1-both (branches split after narrative)
                "\n While Don sleeps soundly..."
                + "\n\n Together, you and Main() begin searching the house for the missing snippets."
                + "\n In the kitchen you notice a strange glow under the table and you move in to investigate."
                + "\n To your surprise, upon touching the glowing object a question appears..."
                + "\n\n Q: Namespace is a container that groups things, such as classes, together. (T/F)",
        //1.1-correct answer branch
                "\n --'WOW! You sure know your stuff!' Main() exclaims." 
                + "\n As you joyously high five each other, " 
                + "\n\n SUDDENLY the glowing object is absorbed into Main()!" 
                + "\n\n -- 'Whoa!' says Main ()." 
                + "\n Simultaneously both of you eagerly blurt out, 'That was crazy! Let's keep looking!!!'",
        //1.1-incorrect answer branch
                "\n -- 'Don't worry, we'll have better luck next time,' Main() says.",
        //1.1-both (branches overlay)
                " You walk up to the fridge and peek inside, you could sure go for a snack. " 
                + "\n\n --'Anything in there?,' says Main()." 
                + "\n Nothing yet, as you peruse the leftovers...",
        //1.1-correct answer branch
                " As you close the fridge you notice the snippet dropped a piece of paper. " 
                + "\n You pick it up... a class is a container that groups things, such as methods, together." 
                + "\n Neat! Hopefully that will come in handy later.",
        //1.1-incorrect answer branch
                " As you close the fridge you notice a piece of paper,... Namespace..." 
                + "\n According to this, Namespace IS a container that groups things, together." 
                + "\n\n Hmmm, you scratch your head, that would have been nice to know earlier.",
        //1.1-both (branches reconnect)
                " Main() walks over and together you leave the kitchen to explore other areas of the house...",
        };
        
        static string[] encounter2 = {
        //7 element string[] of dialouge for encounter2 will go inside this array
                
        //1.2-both (branches split)
                " Searching the house, you enter the study. " 
                + "\n\n --'This might be a good place to find a snippet,' says Main()." 
                + "\n Wondering through the many books, you notice there seem to be several in C#..." 
                + "\n You pick up one of the books and it starts to glow..." 
                + "\n\n Q: A class is a container that groups things, such as m______, together.",
        //1.2-correct answer branch 
                "\n --Exactly! exclaims Main()." 
                + "\n As the glowing snippet is absorbed into Main()",
        //1.2-incorrect answer branch
                "\n --'That's a tough one,' Main() says. " 
                + "\n Hopefully you spelled it corectly..." 
                + "\n *Remember spelling is important in programming.",
        //1.2-both (branches overlay)
                "\n You continue to search the study, hoping another snippet will be found.",
        //1.2-correct answer branch 
                "\n On the desk you notice something interesting on a sticky note..." 
                + "\n ... a variable can be used to store some value for later..." 
                + "\n Interesting... hopefully that is useful later, as you take a mental note.",
        //1.2-incorrect answer branch
                "\n On the desk you notice a sticky note that says," 
                + "\n A class IS a container that groups things like methods together..." 
                + "\n ... face palm...",
        //1.2-both (branches reconnect) 
                "\n Just as you finish reading Main() walks over. " +
                "\n And together you leave the study to explore other areas of the house...",
        };

    static string[] encounter3 = {
        //7 element string[] of dialouge for encounter3 will go inside this array
        
        //1.3-both (branches split) 
                " Leaving the study you make your way to the living room." 
                + "\n\n --'I'll check under the couch,' says Main()" 
                + "\n You begin to search around the television and to your surpise a little glow appears..." 
                + "\n\n Q: In programming, a variable can be used to store some value for later use. (T/F)",
        //1.3-correct answer branch
                "\n --Hurray!!! Main() exclaims." 
                + "\n As the little snippet bounces off of the console towards Main()",
        //1.3-incorrect answer branch 
                " --'Oh noooo! He's floating array... I mean away.' says Main(), "
                + "\n 'Oh well let's keep looking.'",
        //1.3-both (branches overlay 
                "\n Together you continue looking around the living room.",
        //1.3-correct answer branch
                "\n Noticing a stack of VHS tapes, you become intrigued..."
                + "\n On the back of one of the tapes you read the description...," 
                + "\n ...Data types: decimal has a higher accuracy than double, int can store whole numbers...",
        //1.3-incorrect answer branch 
                " When suddenly you spot an unusual item," 
                + "\n You pick it up and read aloud, V-H-S tape... whatever that means..." 
                + "\n On the back of the tape you notice something familiar," 
                + "\n\n ...A variable can be used to store some value for later..." 
                + "\n Ah, you think to yourself.",
        //1.3-both (branches reconnect)
                "\n While putting the tape back, Main() walks over..." 
                + "\n\n --'Welp I think we've exhausted this place, let's look somewhere else.'" 
                + "\n You agree, and make your way to the front of the house." 
                + "\n As you open the door, Main() excitedly says..." 
                + "\n\n --'Hello World!'",
        };

        public static void RandLootQ1()
        {
            //creates new instance of RandItem class
            RandLoot RandLootQ1 = new RandLoot();
            WriteLine("\nYou did a great job here " + playerName + ", thanks for all your help! I found this along the way: *Main hands you a \n" + RandLootQ1.name + "! " + RandLootQ1.description);
            //adds new RandItem object to running Inventory List
            LootWon.Add(RandLootQ1.name);
        }

        public static void helloWorld()
        {
            Console.Title = "Hello World!";

            for (int encounter = 1; encounter < 4 ; encounter++)
            {
                string plyrInput = "";

                switch (encounter)
                {
                    case 1:
                        WriteLine(encounter1[0]);

                        WriteLine(" Please enter your answer: ");
                        Write(" ");
                        plyrInput = ReadLine();
                        plyrInput = plyrInput.ToLower();
                        
                        if (plyrInput == "t")
                        {
                            WriteLine(encounter1[1]);

                            CodeSnippet Q1Lvl1 = new CodeSnippet();
                            Q1Lvl1.name = "Code Snippet 1.1";
                            //adds newly absorbed code snippet
                            CodeAbsorbed.Add(Q1Lvl1.name);
                        }
                        else
                        {
                            WriteLine(encounter1[2]);
                        }
                        
                        WriteLine(encounter1[3]);
                        
                        if (plyrInput == "t")
                        {
                            WriteLine(encounter1[4]);
                        }
                        else
                        {
                            WriteLine(encounter1[5]);
                        }

                        WriteLine(encounter1[6]);

                        break;

                    case 2:
                        WriteLine(encounter2[0]);

                        WriteLine(" Please enter your answer: ");
                        Write(" ");
                        plyrInput = ReadLine();
                        plyrInput = plyrInput.ToLower();


                        if (plyrInput == "methods")
                        {
                            WriteLine(encounter2[1]);

                            CodeSnippet Q2Lvl1 = new CodeSnippet();
                            Q2Lvl1.name = "Code Snippet 1.2";
                            //adds new Item object to running Inventory List
                            CodeAbsorbed.Add(Q2Lvl1.name);
                        }
                        else
                        {
                            WriteLine(encounter2[2]);
                        }

                        WriteLine(encounter2[3]);

                        if (plyrInput == "methods")
                        {
                            WriteLine(encounter2[4]);
                        }
                        else
                        {
                            WriteLine(encounter2[5]);
                        }

                        WriteLine(encounter2[6]);

                        break;

                    case 3:
                        WriteLine(encounter3[0]);

                        WriteLine(" Please enter your answer: ");
                        Write(" ");
                        plyrInput = ReadLine();
                        plyrInput = plyrInput.ToLower();

                        if (plyrInput == "t") 
                        {
                            WriteLine(encounter3[1]);

                            CodeSnippet Q3Lvl1 = new CodeSnippet();
                            Q3Lvl1.name = "Code Snippet 1.3";
                            //adds new Item object to running Inventory List
                            CodeAbsorbed.Add(Q3Lvl1.name);
                        }
                        else
                        {
                            WriteLine(encounter3[2]);
                        }

                        WriteLine(encounter3[3]);

                        if (plyrInput == "t") 
                        {
                            WriteLine(encounter3[4]);
                            
                        }
                        else
                        {
                            WriteLine(encounter3[5]);
                        }

                        WriteLine(encounter3[6]);

                        break;

                }
                WriteLine("\n\n**Press the space bar to continue...");
                ReadKey();
                Clear();
            }           
        }


    }
}
