using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            var EightLegs = new Spider();
            EightLegs.type = "spider";
            EightLegs.height = 2;
            EightLegs.isVenomous = true;
            EightLegs.bugsInWeb = 9;

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("var EightLegs ********************************************************************");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine(EightLegs.terrify());
            Console.WriteLine(EightLegs.bugsCaughtInWeb());


            var Kong = new Gorilla();
            Kong.type = "gorilla";
            Kong.height = 84;
            Kong.weight = 900;
            Kong.numberOfBananas = 117;

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("var Kong *************************************************************************");
            Console.WriteLine("----------------------------------------------------------------------------------");
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
            Odder.type = "otter";
            Odder.height = 11;
            Odder.weight = 30;
            Odder.toy = "glittery rock";
            
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("var Odder ***********************************************************************");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine(Odder.identify());
            Console.WriteLine(Odder.measure());
            Console.WriteLine(Odder.weigh());
            Console.WriteLine(Odder.playingWithToy());
            Console.WriteLine(Odder.swim());
            Console.WriteLine(Odder.sleep());


            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Sentence with all 3 animals ******************************************************");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"There is an {Odder.type} named {Odder.name}, a {Kong.type} named {Kong.name}, and a {EightLegs.type} named {EightLegs.name}.");
        

            //Testing base/override for version-2:
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Function attack() base/override demonstration ************************************");
            Console.WriteLine("----------------------------------------------------------------------------------");
            EightLegs.attack();
            Kong.attack();
            Odder.attack();
        }
    }
}