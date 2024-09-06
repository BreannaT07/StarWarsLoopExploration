using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLoopExploration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShipLaunch();
            RebelSquadron();
            SecurityPassword();
            ShipRepair();

            Console.ReadLine();
        }
        // For Loop
        static void ShipLaunch()
        {
            Console.WriteLine("Rebel X-Wing Squadron Lunch Countdown:");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"Launching X-Wing in {i}...");
            }
            Console.WriteLine("All X-Wings have luanched for the rebel attack!");
        }
        // Foreach Loop
        static void RebelSquadron()
        {
            string[] starWarsCharacters = { "Luke Skywalker", "Leia Organa", "Han Solo", "Chewbacca", "R2-D2" };

            Console.WriteLine("\nRebel Squadron Members:");
            foreach (string character in starWarsCharacters)
            {
                Console.WriteLine(character);
            }
        }
        // While Loop
        static void SecurityPassword()
        {
            string password = "";
            string correctPassword = "The Force";

            while (password != correctPassword)
            {
                Console.WriteLine("\nEnter the password to access the Rebel base:");
                password = Console.ReadLine();

                if (password != correctPassword)
                {
                    Console.WriteLine("Incorrect password! Try again.");
                }
            }

            Console.WriteLine("Access granted. Welcome to the Rebel Base!");
        }
        // Do-While Loop:
        static void ShipRepair()
        {
            int menuChoice = 0;

            do
            {
                Console.WriteLine("\nStarfighter Maintenance Menu:");
                Console.WriteLine("1. Repair X-Wing");
                Console.WriteLine("2. Repair Y-Wing");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    switch(menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Repairing X-Wing...");
                            break;
                        case 2:
                            Console.WriteLine("Repairing Y-Wing...");
                            break;
                        case 3:
                            Console.WriteLine("Exiting the menu.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                }
            }
            while (menuChoice != 3);

            Console.WriteLine("May the Force be with you!");
        }
    }
}