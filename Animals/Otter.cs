using System;

namespace Zoolandia
{
    public class Otter: Animals
    {
        public string toy { get; set; }

        public string playingWithToy()
        {
            return name + "the otter is playing with its " + toy + " that it found in some guy's boat when he wasn't looking.";  
        }

        public string swim()
        {
            return name + " the otter is swimming, trying to sneak up and pull down your swim trunks.";
        }

        public override string attack()
        {
            return name + " is throwing its " + toy + " at you. You probably deserve it, you disappointment.";
        }

    }
} 