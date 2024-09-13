using System;

namespace Numbers_and_math
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Nate Barnes



            Console.WriteLine("I will now count my chickens");
            Console.WriteLine("Hens" + (10 + 5 * 2));
            Console.WriteLine("Roosters" + (25 + 30 / 6));
            Console.WriteLine("six" + 6);
            Console.WriteLine();
            Console.WriteLine();
           
            Console.WriteLine("I will now count my eggs:");
            Console.WriteLine(11.0 / 2);
            Console.WriteLine();
            Console.WriteLine(" Is it true that 3 + 2 > 5 - 7?");
            Console.WriteLine(3 + 2 > 5 - 7);
            Console.WriteLine("What is 3 + 2? " + (3 + 2));
            Console.WriteLine("Oh, thats why it's " + (3 + 2 > 5 - 7));
            //Putting the equation in double quotes asks the comuter a question that should be anwered with text, instead of numbers.
            Console.WriteLine();
            Console.WriteLine("What is 8 * 21? " + (8 * 21).ToString("C"));
            Console.WriteLine();
            Console.WriteLine("One egg costs " + (6.0/12).ToString("C"));
            Console.WriteLine();
            Console.WriteLine("The tax on $79.99 s " + (79.99 * 0.13).ToString("C"));
            Console.WriteLine();
            Console.WriteLine("There are " + (5 * 12 + 6) * 2.54 + " centimeters in 5'6");
            Console.WriteLine();
            
           
            // Nate Barnes
            Console.WriteLine("I was born in " + (2024 - 16));
            Console.WriteLine();
            Console.WriteLine((14.0 + 15.0 + 16.0) / 3);
            // That is the average of 14 15 and 16.
            Console.WriteLine((14.0 + 15.0 + 16.0 + 17.0) / 3);
            Console.WriteLine();
            Console.WriteLine("I will now calculate the area of a circle.");
            Console.WriteLine((3.1415 * 9.0));
            Console.WriteLine();
            Console.WriteLine("C# knows to add when you use + because it looks on either side of the plus sign and vinds the value.");






        }


    }
}
