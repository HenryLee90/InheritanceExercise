using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal---done
            // give this class 4 members that all Animals have in common---done


            // Create a class Bird--done
            // give this class 4 members that are specific to Bird--done
            // Set this class to inherit from your Animal Class---done

            // Create a class Reptile---Done
            // give this class 4 members that are specific to Reptile---Done
            // Set this class to inherit from your Animal Class---Done




            /*Create an object of your Bird class---Done
             *  give values to your members using the object of your Bird class---Done
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird bird1 = new Bird();
            bird1.Beak = true;
            bird1.Wings = true;
            bird1.Legs = 2;
            bird1.Feathers = true;
            bird1.Size = "Small";
            bird1.Age = 2;
            bird1.Tail = true;
            Console.WriteLine($"This animals beak is really {bird1.Size} this animal has {bird1.Legs} legs." +$"He has blue feathers {bird1.Feathers}.\n" +
                $"And he is {bird1.Age} years old.");

            Reptiles liz1 = new Reptiles()
            {
                Scales = true,
                ForkedTounge = true,
                ColdBlooded = true,
                Length = 9.43,
                Age = 16,
                Legs = 4,
                Tail = true,

            };
            Console.WriteLine($"This Lizard named Daisy is a Kamodo Dragon. She is {liz1.Length} feet long!!! \n She is a WOPPING {liz1.Age} year old. She has armor like scales!!! {liz1.Scales}");

        }
    }
}
