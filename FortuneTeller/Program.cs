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
            //Each time input is required from user, include option to end program by typing "quit"

            Console.WriteLine("Welcome to the Virtual Fortune Teller\n");
            Console.WriteLine("If at any point you wish to exit the Fortune Teller, enter \"Quit\"\n");
            Console.WriteLine("Please answer the following questions to receive your fortune\n");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            if (firstName.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            if (lastName.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            Console.WriteLine("How old are you?");
            string responseToAge = (Console.ReadLine());
            if (responseToAge.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            int age = int.Parse(responseToAge);
            Console.WriteLine("What is your birth month?");
            string responseToBirthMonth = Console.ReadLine();
            string responseToBirthMonthLower = responseToBirthMonth.ToLower();
            if (responseToBirthMonthLower == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            int birthMonth;
            //convert user's birth month to an int
            switch (responseToBirthMonthLower)
            {
                case "january":
                    birthMonth = 1;
                    break;
                case "february":
                    birthMonth = 2;
                    break;
                case "march":
                    birthMonth = 3;
                    break;
                case "april":
                    birthMonth = 4;
                    break;
                case "may":
                    birthMonth = 5;
                    break;
                case "june":
                    birthMonth = 6;
                    break;
                case "july":
                    birthMonth = 7;
                    break;
                case "august":
                    birthMonth = 8;
                    break;
                case "september":
                    birthMonth = 9;
                    break;
                case "october":
                    birthMonth = 10;
                    break;
                case "november":
                    birthMonth = 11;
                    break;
                case "december":
                    birthMonth = 12;
                    break;
                default:
                    birthMonth = 0;
                    break;
            }
            Console.WriteLine("What is your favorite ROYGBIV color?\n(Enter \"Help\" if you need to see a list of ROYGBIV colors)");
            string responseToColor = Console.ReadLine();
            string color;
            if (responseToColor.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            //Provide ROYGBIV colors if user enters "Help" (regardless of case) and then re-ask for fave color and convert color to lower case
            if (responseToColor.ToLower() == "help")
            {
                Console.WriteLine("\nThe ROYGBIV colors are as follows:\n\n   R: Red\n   O: Orange\n   Y: Yellow\n   G: Green\n   B: Blue\n   I: Indigo\n   V: Violet");
                Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
                color = Console.ReadLine().ToLower();
                if(color == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    return;
                }
            }
            else
            {
                color = responseToColor.ToLower();
            }
            Console.WriteLine("How many siblings do you have?");
            string responseToSiblings = Console.ReadLine();
            if (responseToSiblings.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            int siblings = int.Parse(responseToSiblings);
            
            //Part 2
            //Determine user's retirement time, amount of $ in bank, vacation home location, and mode of transport using their age, birthmonth, # of siblings, and fave color respectively

            string numberOfYears;        //use age
            string amountOfMoney;        //use birth month
            string location;             //use # of siblings
            string modeOfTransportation; //use fave color

            //Determine retirement time
            if ((age % 2) == 0)
            {
                numberOfYears = "10 years";
            }
            else
            {
                numberOfYears = "25 years";
            }

            //Determine money in bank

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                amountOfMoney = "$1 million";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                amountOfMoney = "$10 million";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                amountOfMoney = "$1 billion";
            }
            else
            {
                amountOfMoney = "$0";
            }

            //Determine location

            if (siblings == 0)
            {
                location = "Palm Beach";
            }
            else if (siblings == 1)
            {
                location = "Aspen";
            }
            else if (siblings == 2)
            {
                location = "the Hamptons";
            }
            else if (siblings == 3)
            {
                location = "Paris";
            }
            else if (siblings >= 4)
            {
                location = "Hawaii";
            }
                else
            {
                location = "a trailer park";
            }

            //Determine mode of transportation
            
            switch (color)
            {
                case "red":
                    modeOfTransportation = "Toyota Camry";
                    break;
                case "orange":
                    modeOfTransportation = "yacht";
                    break;
                case "yellow":
                    modeOfTransportation = "motorcycle";
                    break;
                case "green":
                    modeOfTransportation = "unicycle";
                    break;
                case "blue":
                    modeOfTransportation = "pair of feet";
                    break;
                case "indigo":
                    modeOfTransportation = "Razor scooter";
                    break;
                case "violet":
                    modeOfTransportation = "jet";
                    break;
                default:
                    modeOfTransportation = "suspended driver's license because you did not choose a proper ROYGBIV color as your favorite";
                    break;
            }

            //Part 3           
            //Print fortune
            
            Console.WriteLine("\nHere is your fortune:\n\n{0} {1} will retire in {2} with {3} in the bank, a vacation home in {4} and a {5}.", firstName, lastName, numberOfYears, amountOfMoney, location, modeOfTransportation);
                        
        }
    }
}
