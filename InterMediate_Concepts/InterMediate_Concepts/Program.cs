using System;
using System.Collections.Generic;

namespace InterMediateConcepts
{
   

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("\n--- MAIN MENU ---");
                Console.WriteLine("1. Collections and Generics Examples");
                Console.WriteLine("2. Events, Delegates, and Lambdas");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        InterMediateConcepts1.DemoFeatures._1st_Part();
                        
                        break;
                    case "2":
                        InterMediateConcepts2._2nd_Part();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
