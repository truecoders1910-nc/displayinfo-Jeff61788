using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            // Get their favorite number
            // Get their favorite animal

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.


            Console.WriteLine("What is Your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName}!");

            Console.WriteLine("What Is Your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Nice To Meet You {firstName} {lastName}!");

            Console.WriteLine("What Is Your Favorite Number?");
            int favNum = Convert.ToInt32 (Console.ReadLine());
            if (favNum > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (favNum < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"Your Favorite Number is {favNum}!");
            Console.ResetColor();

            Console.WriteLine("What Is Your Favorite Animal");
            string animal = Console.ReadLine();
            Console.WriteLine($"Your Favorite Animal is {animal}");
            
           
        }
            
    }
}
