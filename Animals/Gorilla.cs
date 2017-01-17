using System;

namespace Zoolandia
{
    class Gorilla: Animals
    {
        public int numberOfBananas { get; set; }
        
        public Gorilla()
        {
            canDoMath = false;
        }
        public bool canDoMath { get; set; }

        public string beatChest()
        {
            return name + " the gorilla is beating his chest. You should probably leave.";
        }

        public string mathing()
        {
            if (canDoMath == true)
            {
                return name + " can do math. Look... 12 divided by 3 is purple. " + name + " is still practicing.";
            }
            else
            {
                return name + " cannot do math. " + name + " is a gorilla, you idiot.";
            }
        }

    }
} 