# zoolandia

Instructions

Sub-directories

Creating sub-directories in your project is a way to accomplish code management at the physical file system, so that you don't end up with dozens of classes all in same level in your project.

Create an Animals subdirectory in your project. All of your animal-related classes will be created that directory.
Namespaces

Using namespaces is another way to organize your classes at the code level. Think of them as simple buckets in which related classes exist.

Ensure that each of your animal classes belong to the Zoolandia.Animals namespace.
Making Animals

Create your first C# class - the Animal class. Create some simple properties and methods on Animal. You are going to create some derived classes that inherit from Animal, so make sure that the properties/methods you add are general to all Animals (e.g. name, height, weight, etc).

Example property/method definition

namespace Zoolandia.Animals
{
    class Animal
    {
        public string name { get; set; }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    }
}
After you are happy with your Animal class, create a derived class that defines a particular species of Animal. Create some properties that apply only to that species.

namespace Zoolandia.Animals
{
    // The species for a Red Pana
    class AilurusFulgens : Animal
    {
        // Define simple properties for a Red Panda
    }
}
Create three more classes for species of animals of your choosing. Wikipedia is a great tool to discover species names. Make sure you use a mix of native C# types for your properties.

Create some instances of your species.
Assign values to the properties of each.
Use Console.WriteLine(); to output the property values of your animals to the console.

// Example
Console.WriteLine($"I have a Squirrel named {squirrel.name} who makes a 
noise that sounds like {squirrel.signatureNoise}. I'd rate its cuteness 
at {squirrel.cutenessFactor}.");