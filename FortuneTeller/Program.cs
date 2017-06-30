using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //Collect user input & initialize variables

            Console.WriteLine("Welcome to the Virtual Fortune Teller\n");
            Console.WriteLine("Please answer the following questions to receive your fortune\n");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite ROYGBIV color?\n(Enter \"Help\" if you need to see a list of ROYGBIV colors)");
            string responseToColor = Console.ReadLine();
            string color;
            if(responseToColor.ToLower() == "help")
            {
                Console.WriteLine("\nThe ROYGBIV colors are as follows:\n\n   R: Red\n   O: Orange\n   Y: Yellow\n   G: Green\n   B: Blue\n   I: Indigo\n   V: Violet");
                Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
                color = Console.ReadLine();
            }
            else
            {
                color = responseToColor;
            }
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            


          

        }
    }
}
