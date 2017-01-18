using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            var EightLegs = new Spider();
            EightLegs.name = "Dave";
            EightLegs.type = "spider";
            EightLegs.height = 2;
            EightLegs.isVenomous = true;
            EightLegs.bugsInWeb = 9;

            Console.WriteLine(EightLegs.terrify());
            Console.WriteLine(EightLegs.bugsCaughtInWeb());


            var Kong = new Gorilla();
            Kong.name = "Donkey";
            Kong.type = "gorilla";
            Kong.height = 84;
            Kong.weight = 900;
            Kong.numberOfBananas = 117;

            Console.WriteLine(Kong.identify());
            Console.WriteLine(Kong.measure());
            Console.WriteLine(Kong.weigh());
            Console.WriteLine(Kong.name + " has " + Kong.numberOfBananas + " bananas."); 
            Console.WriteLine(Kong.eat());
            Console.WriteLine(Kong.mathing());
            Kong.canDoMath = true;
            Console.WriteLine(Kong.mathing());
            Console.WriteLine(Kong.beatChest());


            var Odder = new Otter();
            Odder.name = "Charlotter";
            Odder.type = "otter";
            Odder.height = 11;
            Odder.weight = 30;
            Odder.toy = "glittery rock";
            Console.WriteLine(Odder.identify());
            Console.WriteLine(Odder.measure());
            Console.WriteLine(Odder.weigh());
            Console.WriteLine(Odder.playingWithToy());
            Console.WriteLine(Odder.swim());
            Console.WriteLine(Odder.sleep());


            Console.WriteLine($"There is an {Odder.type} named {Odder.name}, a {Kong.type} named {Kong.name}, and a {EightLegs.type} named {EightLegs.name}.");
        }
    }
}