using System;

namespace Zoolandia
{
    class Spider: Animals
    {
        public bool isVenomous { get; set; }

        public Spider()
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

    }
} 