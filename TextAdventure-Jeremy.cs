using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to publix!");
            Console.WriteLine("Would you like to know you can get free antibiotics?");

            string response = Console.ReadLine();

            if (response == "Yes")
            {
                Console.WriteLine("Do you have a prescription from your physician?");
                response = Console.ReadLine();

                if (response == "Yes") ;
                Console.WriteLine("Is it bactrim ds?");
                Console.ReadLine();

                Console.WriteLine("It's free we will fill your prescription. Come back in 15 mins!");
            }
    }
}
