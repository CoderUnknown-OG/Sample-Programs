using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey bro 👋, your C# setup is working perfectly!");
            Console.WriteLine("-----------------------------------------------");

            // Variables
            string name = "Gowtham";
            int age = 18;
            double cgpa = 9.1;

            // Output
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"CGPA: {cgpa}");

            // Simple if-else
            if (cgpa >= 9)
                Console.WriteLine("🔥 Excellent performance, bro!");
            else
                Console.WriteLine("Keep pushing harder 💪");

            // Loop example
            Console.WriteLine("\nCounting from 1 to 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number {i}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

