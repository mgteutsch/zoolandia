using System;

namespace Zoolandia
{
    public class Spider: Animals
    {
        public Spider()
        {
            this.name = "Dave";
        }
       
        public bool isVenomous { get; set; }

        public Spider(bool isRightBehindYou)
        {
            isRightBehindYou = true;
        }
        public bool isRightBehindYou { get; set; }

        public int bugsInWeb { get; set; }

        
        public string bugsCaughtInWeb()
        {
            return name + " the spider has " + bugsInWeb + " bugs caught in his web. You may be next!";
        }

        public string terrify()
        {
            if (isRightBehindYou == true)
            {
                return "You feel that? On the back of your neck? That's " + name + ". " + name + " is a spider."; 
            }
            else
            {
                return "You are safe from " + name + " the spider. For now.";
            }
        }

        
        //This doesn't work, and I'd like to know why:
        //*****************************************************
        public override void attack()
        {
            if (isVenomous == true)
            {
                Console.WriteLine($"{name} just bit you... you likely said something stupid. Also, you should probably go to a hospital before that swells and explodes and makes a whole mess of the place.");
            }
            else
            {
                Console.Write($"{name} just bit you. It's not a venomous bite, but I'd treat this as a warning shot before {name} starts calling up some friends.");
            }
        }
        //*****************************************************
        // public override void attack()
        // {
        //     Console.WriteLine($"{name} just bit you. This is not fun.");
        //     Console.WriteLine("The bite is so painful, it is setting you back to the base.attack() function:");
        //     base.attack();
        // }
    
    }
} 