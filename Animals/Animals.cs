using System;

namespace Zoolandia
{
    class Animals
    {
        public string name { get; set; }
        public string type { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        public string identify()
        {
            return "This is " + name + ". " + name + " is a " + type + ".";
        }
        public string eat()
        {
            return name + " is eating.";
        }

        public string sleep()
        {
            return name + " is sleeping.";
        }

        public string measure()
        {
            return name + " is " + height + " inches tall.";
        }
        public string weigh()
        {
            return name + " weighs " + weight + " pounds."; 
        }
    }
} 