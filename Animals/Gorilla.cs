using System;

namespace Zoolandia
{
    public class Gorilla: Animals
    {
        public Gorilla()
        {
            this.name = "Donkey";
        }
        public int numberOfBananas { get; set; }
        
        public Gorilla(bool canDoMath)
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

        public override void attack()
        {
            Console.WriteLine($"{name} is charging at you with the wrath of a thousand prehistoric beasts, but is also delicately holding his banana making sure to not drop it while you are pummelled into a pancake, because that would be a waste of a perfectly good banana.");
        }

    }
} 