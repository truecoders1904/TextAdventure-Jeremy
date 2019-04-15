using System;

namespace TextAdventure1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Jeremy's learnsource!");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Today we will work on a english.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Dont worrry it'll be fun!");

            {
                Console.WriteLine("Let's get started!");
                Console.WriteLine("Can you tell me your name?");
                Console.ReadLine();
                Console.WriteLine("What an awsome name you have!");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Ok let's start off with Q1.");

                Console.WriteLine("To move on to the next level you must  enter the word(s) that will make the sentence correct.");
                System.Threading.Thread.Sleep(3000);

            }
            String choices;
            do
            {

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Peter is coming back home ______school");
                Console.WriteLine("had");
                Console.WriteLine("from");
                Console.WriteLine("has");
                Console.WriteLine("give");
                Console.WriteLine("giving");

                Console.WriteLine("Pick a answer, but only one will do.");

                choices = Console.ReadLine();

                if (choices.ToLower() == "had")
                {
                    Console.WriteLine("Not quite, try again");
                }
                else if (choices.ToLower() == "from")
                {
                    Console.WriteLine("Great you got it!");
                }
                else if (choices.ToLower() == "has")
                {
                    Console.WriteLine("Not quite, dont give up. try again");
                }
                else if (choices.ToLower() == "give")
                {
                    Console.WriteLine("Not quite, give it another shot!");
                }
                else if (choices.ToLower() == "giving")
                {
                    Console.WriteLine("Not quite, give it another guess");
                }


            } while (choices.ToLower() != "from");
            Console.WriteLine("Are you ready for you next question?");

            string response;
            response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                Console.WriteLine("ZOOM LETS' GO!");
            }

            Console.WriteLine("Q2");
         

        }


    }
}
