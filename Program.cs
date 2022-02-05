using System;

namespace Rockgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock game.");
            int count = 0;
            int user_input;
            int user_count;
            Random random = new Random();
            int Computer_choice = random.Next(4);
            string option = "0. Rock." + "\n" + "1. Paper." + "\n"+ "2. Scissors.";
            Console.WriteLine(option);

            Console.Write("Rounds : ");
            user_count = Convert.ToInt32(Console.ReadLine());
            while(count < user_count)
            {
                 Console.Write("Enter your choice: ");
                user_input = Convert.ToInt32(Console.ReadLine());

                if(user_input == Computer_choice)
                {
                    Console.WriteLine("Draw.");
                    count += 1;
                }
                //Rock
                else if(user_input == 0 && Computer_choice == 1)
                {
                    Console.WriteLine("Computer Wins.");
                    count += 1;
                }else if(user_input == 0 && Computer_choice == 2)
                {
                    Console.WriteLine("You Win.");
                    count += 1;
                }
                //Paper
                else if(user_input == 1 && Computer_choice == 0)
                {
                    Console.WriteLine("You Win.");
                    count += 1;
                }else if(user_input == 1 && Computer_choice == 3)
                {
                    Console.WriteLine("Computer Wins.");
                    count += 1;
                }
                // Scissors
                else if(user_input == 3 && Computer_choice == 2)
                {
                    Console.WriteLine("You Win.");
                    count += 1;
                }else if(user_input == 3 && Computer_choice == 0)
                {
                    Console.WriteLine("Computer Wins.");
                    count += 1;
                }else
                {
                    Console.WriteLine("Invalid input.");
                }
            }if (count == user_count )
            {
                Console.WriteLine("This is your last time.");
            }
        }
    }
}
