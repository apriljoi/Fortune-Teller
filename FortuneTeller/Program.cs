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

            // This is as fancy as it gets right now, until I learn how to add colors and change fonts!
            Console.WriteLine("***************WELCOME*****************\n");

            Console.WriteLine("Hello, My name is Fortune Teller,\n"); //I figure I should introduce myself first

            //Ask the user for user’s first name

            Console.WriteLine("What is your First Name?");
            string firstName = Console.ReadLine();
            firstName = firstName.ToUpper();

            //Ask the user for the user’s last name
            Console.WriteLine("What is your Last Name?");
            string lastName = Console.ReadLine();
            lastName = lastName.ToUpper();

            Console.WriteLine("Lovely to meet you " + firstName);

            //Ask the user for the user’s age
            Console.WriteLine("Please enter your age\n");
            int userAge = int.Parse(Console.ReadLine());

            //Ask the user for the user’s birth month(as an 'int')
            Console.WriteLine("Please enter the month you were born in as a number (1-12)\n");
            int birthMonth = int.Parse(Console.ReadLine());

            //Ask the user for the user’s favorite ROYGBIV color
            Console.WriteLine("Please enter your favorite ROYGBIV color. \nIf you do not know what ROYGBIV is, enter help.\n");

            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors

            string userColor = Console.ReadLine();
            userColor = userColor.ToUpper();

            if (userColor.ToUpper() == "HELP")
            { Console.WriteLine("\nR-Red\n O-Orange\n Y-Yellow\n G-Green\n B-Blue\n I-Indigo\n V-Violet\n What color would you like to choose?"); }
            userColor = Console.ReadLine();

            //Ask the user for the number of siblings the user has
            Console.WriteLine("How Many siblings do you have? Please enter as a number,\n");
            int userSib = int.Parse(Console.ReadLine());

                        //Part II
            //**Now time to put all the information that I gathered from the user to good use!

            // If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.

            string yayRetirement;

            if (userAge % 2 == 0)
            { yayRetirement = "\n5 years\n"; }

            else
            { yayRetirement = "\nYou will retire in 30 years\n"; }

            //If the user’s number of siblings is 0, then they will have a vacation home in ____(location) 

            string vacationSpot = Console.ReadLine();


            switch (userSib)
            {
                //If the user’s # of siblings is 0, then they will have a vacation home in ____(location) 

                case 0:
                    vacationSpot = "friendly neighborhood McDonald's Play Place!\n";
                    break;

                //or 1 then they will have a vacation home in ____(location)
                case 1:
                    vacationSpot = "inside of your sibling's basement\n";
                    break;

                //or 2 then they will have a vacation home in ____(location)
                case 2:
                    vacationSpot = "\nHawaii. With the amount of sharing you did as a child, you deserve to have a vacation home in a nice place\n";
                    break;

                //or 3 then they will have a vacation home in ____(location)
                case 3:
                    vacationSpot = "\nThe Bahamas. Not just one island, but all of the islands! \nWith 3 siblings, you deserve all the islands!\n";
                    break;

                default:
                    break;
            }
            //or more than 3 then they will have a vacation home in ____(location)

            if (userSib > 3)
            { vacationSpot = "on your own private island! \nAll of your siblings will have their own vacation homes as well, so the sharing has come to an end!\n"; }

            //If the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!
            //What this really means is that if the user enters anything less than 0

            if (userSib < 0)
            { vacationSpot = "the puddle in front of your apartment's dumpster. \nWhat a view of the water whenever it rains!\n"; }

            //Depending on which ROYGBIV color is the user’s favorite
            //they will have a specific mode of transportation(i.e.car, boat, plane, etc.)
            //R-Red- Rocket
            //O-Orange- Orangatang
            //Y-Yellow-Your Shoes
            //G-Green-Money to buy you any form of transportation that you want
            //B-Blue-Boots "These boots were made for walking"
            //I-Indigo-"In I go to whatever vehicle my best friend drives"
            //V-Violet-The Delorean from Back to the Future

            //*****I had an issue at one point and thought it was because I used switch case vs if else...I was so wrong!
            //if (userColor.ToUpper() == "red")
            //{ Console.WriteLine("Your transportation will be a rocket ship"); }

            //else if (userColor.ToUpper() == "orange")
            //{ Console.WriteLine("Your transportation will be an Orangatang"); }

            //else if (userColor.ToUpper() == "yellow")
            //{ Console.WriteLine("Your transportation will be your shoes"); }

            //else if (userColor.ToUpper() == "green")
            //{ Console.WriteLine("Your transportation will be whatever you can buy with all the money you will have"); }

            //else if (userColor.ToUpper() == "blue")
            //{ Console.WriteLine("Your future transportation will be your boots. I'm sure that you have heard that boots were made for walkin, and that's just what they'll do!"); }

            //else if (userColor.ToUpper() == "indigo")
            //{ Console.WriteLine("Your future transportation will be in the passenger seat of whatever vehicle your best friend drives. If they take the bus, then you will be sharing a bus pass with them! After all, you are a great friend."); }

            //else if (userColor.ToUpper() == "violet")
            //{ Console.WriteLine("Your future transportation will be the Dolorean from \"Back to the Future\""); }


            string howIGetAround = Console.ReadLine();  //when I concatenate everything at the end, my paragraph doesn't read this string, yet I have no red squiggles
                                                         //not sure what happened here! Did I not put my variable in the right place?

            switch (userColor.ToUpper())
            {
                case "red":
                    howIGetAround = "a rocket ship";
                    break;

                case "orange":
                    howIGetAround = "an Orangatang";
                    break;

                case "yellow":
                    howIGetAround = "your shoes";
                    break;

                case "green":
                    howIGetAround = "whatever you can buy with all the money you will have";
                    break;

                case "blue":
                    howIGetAround = "boots. I'm sure that you have heard that boots were made for walkin, and that's just what they'll do!";
                    break;

                case "indigo":
                    howIGetAround = "in the passenger seat of whatever vehicle your best friend drives";
                    break;

                case "violet":
                    howIGetAround = "the Dolorean from \"Back to the Future\"";
                    break;

                default:
                    break;
            }

                    //**PART II CONTINUED**

                    string caChing;

                    //If the user’s birth month is 1 - 4, they will have $____ in the bank
                    if (birthMonth >= 1 && birthMonth <= 4)
                    { caChing = "$500.00 dollars in the bank, but just graduated from the \"We Can Code IT\" coding boot camp and landed your first job making $60,000.00 a year, so your account balance will change soon!"; }

                    //if the user's birth month is 5-8, they will have $____ in the bank
                    else if (birthMonth > 4 && birthMonth <= 8)
                    { caChing = "$10,000.00 in the bank, but money invested into McDonald's stock. I think we both know that this means you have the potential to have more money in the bank"; }

                    //and if it is 9-12 then they will have $____ in the bank. 
                    else if (birthMonth > 8 && birthMonth <= 12)
                    { caChing = "1 million dollars in the bank!"; }

                    //If the user enters something other than 1-12 as their birth month, they will have $0.00 in the bank.

                    else
                    { caChing = "$0.00"; }

            
                    //**PART III***

                    //The user’s fortune should be written as such:

                    //[First Name] [Last Name]
                    Console.WriteLine(firstName + "" + lastName + "will retire in " + yayRetirement + " with" + caChing + "," + " a vacation home in " + vacationSpot + "and a" + howIGetAround + ".");
                    //will retire in [# of Years] with [Amount of Money] in the bank
                    //a vacation home in [Vacation Spot] 
                    //and a [Mode of Transportation].
                    //Program should be able to handle whether or not a user inputs capital or lowercase letters.



            }
        }
    }
