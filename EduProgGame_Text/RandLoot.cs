using System;

namespace EduProgGame_Text
{
    public class RandLoot
    {
        public string name;
        public string description;

        //Will need to be at least 25, one for each possible correct answer
        string[] randItems = { 
            "USB Cable", 
            "Variable",
            "Glass of Water"
        };
        string[] randItmDescriptions = { 
            "Maybe this could help Main reconnect when we get back?\n", 
            "Lil guy was lost, good thing you found him!\n",
            "Man, good timing! You were getting thirsty.\n"
        };

        public RandLoot()
        {
            //Instantiates Random class 
            Random randNum = new Random();
            int num;

            //.Next(Int32) returns a non-negative, rand num, less than specified max (as param)
            num = randNum.Next(randItems.Length);
            name = randItems[num];
            description = randItmDescriptions[num];

        }

    };


}
