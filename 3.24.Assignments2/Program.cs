using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._24.Assignments2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu(); //I do this so if people try to not choose a menu item i can just call menu as a function and loop em around. 
        }
        static void Menu()
        {
            Console.WriteLine("It's calculator time!"); //my printed menu
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Which would you like to do?");
            string choice = Console.ReadLine();
            if (choice == "1") //depending on what they choose, calls functions that do each thing
            {
                AddMenu(); //calls my add menu, each below does the same with the properly named menu
            }
            else if (choice == "2")
            {
                SubtractMenu();
            }
            else if (choice == "3")
            {
                MultiplyMenu();
            }
            else if (choice == "4")
            {
                DivideMenu();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thanks for using my calculator!");
            }
            else
            {
                Console.WriteLine("Please pick one of the 5 options!\n");
                Menu();
            }
        }
        static void AddMenu() //made it a function so I can loop it if people mess around with inputting incorrect stuff, each menu below is done the same!
        {
            Math math = new Math();
            int num1;
            int num2;
            Console.WriteLine("What is the first number you'd like to add?");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number you'd like to add?");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The answer is: {0}", math.Add(num1, num2));
                choicemenu(); //so I made asking if they want to do another calculation it's own function for easier looping
            }
            catch
            {
                    Console.WriteLine("You entered something that wasn't a whole number! \n");
                    AddMenu(); //they BEST BE PUTTING IN A WHOLE NUMBER 
            }
        }
        static void SubtractMenu()
        {
            Math math = new Math();
            int num1;
            int num2;
            Console.WriteLine("What is the first number you'd like to take from?");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What number would you like to subtract from it?");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The answer is: {0}", math.Subtract(num1, num2));
                choicemenu();
            }
            catch
            {
                Console.WriteLine("You entered something that wasn't a whole number! \n");
                SubtractMenu();
            }
        }
        static void MultiplyMenu()
        {
            Math math = new Math();
            int num1;
            int num2;
            Console.WriteLine("What is the first number to multiply?");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number to multiply?");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The answer is: {0}", math.Multiply(num1, num2));
                choicemenu();
            }
            catch
            {
                Console.WriteLine("You entered something that wasn't a whole number! \n");
                MultiplyMenu();
            }
        }
        static void DivideMenu()
        {
            Math math = new Math();
            int num1;
            int num2;
            Console.WriteLine("What is the numerator?");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the denomenator?");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The answer is: {0}", math.Divide(num1, num2));
                choicemenu();
            }
            catch
            {
                Console.WriteLine("You entered something that wasn't a whole number! \n");
                DivideMenu();
            }
        }
        static void choicemenu() //this is my function for asking if they'd like to do more stuff, made easy so i can loop
        {
                Console.WriteLine("Do you want to do another calculation? Y/N");
                string choice = Console.ReadLine();
                if (choice == "Y" || choice == "y") //if they say Y or y it'll take them back to main menu
                {
                    Menu();
                }
                else if (choice == "N" || choice == "n") //if they say n or N it'll thank them then end the app!
                {
                Console.WriteLine("Thanks for using my calculator!");
                }
            else //if they put something other than Y, y, N, or n, I loop them through this menu infinitely! Muahahahaha
            {
                Console.WriteLine("Choose an option! Y/N \n");
                choicemenu();
            }
        }
    }
}
