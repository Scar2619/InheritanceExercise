using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Bird kiwi = new Bird();
            kiwi.Legs = 2;
            kiwi.CanFly = false;
            kiwi.HollowBones = true;
            kiwi.Color = "greyish brown";
            kiwi.FavFood = "plants";
            kiwi.Migrate = false;
            kiwi.HomeBase = "New Zealand";

            Reptile croc = new Reptile();
            croc.Legs = 4;
            croc.Color = "dark green in adulthood";
            croc.FavFood = "meat";
            croc.Shed = true;
            croc.LivingSpace = "wetlands";
            croc.SmellTool = "nose, unlike some other reptiles";
            croc.ColdBlooded = true;


            Console.WriteLine($"Wow! Crocodiles are pretty cool. "
                + $"They have {croc.Legs} legs, are {croc.Color}, and their favorite food is {croc.FavFood}. "
                + $"Crocodiles live in {croc.LivingSpace} across the world. To smell, they use their {croc.SmellTool}. ");
            Console.WriteLine();
            Console.WriteLine($"Another cool animal is the kiwi! The kiwi is a type of bird found in {kiwi.HomeBase}. "
                + $"They are {kiwi.Color}, eat {kiwi.FavFood}, and have {kiwi.Legs} legs. "
                + $"They do not fly and don't migrate either. ");


           /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */



        }
    }
}
