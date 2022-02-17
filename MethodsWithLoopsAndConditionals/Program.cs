using System;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        // generic program to obtain a valid intenger from user input

        static public int GetNum(string userPrompt)
        {
            Int32 userInt = 0;
            bool validUserInt = false;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out userInt))
                {
                    validUserInt = true;
                    Console.WriteLine("Thanks!\n");
                }
                else
                {
                    Console.WriteLine("Sorry, this is not a valid input. You need to provide an Integer, retry please:  ");
                }
            }
            while (!validUserInt);
            return userInt;
        }



        //1 - a method that will print to the console all numbers 1000 through -1000.
        static public void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; --i)
            {
                Console.Write($"* {i} *");
            }
        }

        //2 - a method that will print to the console numbers 3 through 999 by 3 each time.
        static public void SkippingIn3()
        {
            for (int i = 3; i<1000; i+=3)
            {
                Console.Write($" - {i} -");
            }
        }

        //3 - 2 functions that accept two integers as parameters and check whether they are equal or not.

        static public void PrintNumComparison()

        {
            Console.Write("Hi! I bet you want to play with numbers after seeing so many of them on your screen! Let's compare two numbers of your choosing. Type in first whole number and press Enter:  ");
            var firstNum = GetNum("");
            Console.WriteLine("What other number should we compare it to (don't forget to press the magic button again):  ");
            var secondNum = GetNum("");
            
            NumComparison(firstNum, secondNum);
        }
        static public void NumComparison(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                Console.WriteLine($"{firstNum} is greater than {secondNum}. Game is over. But there is another one!\n");
            }
            else if (firstNum < secondNum)
            {
                Console.WriteLine($"{firstNum} is less than {secondNum}. Game is over. But there is another one!\n");
            }
            else
            {
                Console.WriteLine($" {firstNum} equals to {secondNum}. Game is over. But there is another one!\n");
            };
        }



        //4 - a method to check whether a given number is even or odd
        
        static public void PrintEvenOrOdd()

        {
            Console.Write("I can determine if a number is even or odd. Type in a whole number and press enter:  ");
            var userInputNum = GetNum("\n");
            
            if (userInputNum % 2 == 0)
                {
                Console.WriteLine($"{userInputNum} is an even number. \n");
                }
            else
                {
                Console.WriteLine($"{userInputNum} is odd.\n");
                };
        }

        //5 - a method to check whether a given number is positive or negative

        static public void PositiveOrNegative()

        {
            Console.Write("I can determine if a number is positive or negative too. Type in a whole number and press enter:  ");
            var usersNum = GetNum("\n");
            

            if (usersNum == 0)
            {
                Console.WriteLine("0 is 0. It is neither positive nor negative. Perhaps you were just checking if I knew that 8)");
            }
            else if(usersNum < 0)
            {
                Console.WriteLine($"{usersNum} is very negative. Don't be like {usersNum}.\n");
            }
            else
            {
                Console.WriteLine($"{usersNum} is positive. That's all for our +- game.\n");
            };
        }

        //6 - a method to read the age of a candidate and determine whether they can vote.

        static public void VotingAge()
        {
            Console.Write("Let's determine if you can participate in federal elections. Please type in your age and press enter:  ");
            var usersAge = GetNum("\n");
            
            if (usersAge < 18)
            {
                Console.WriteLine("Sorry, you cannot legally vote in federal elections, but some states allow young voters to participate in primary ones.");
            }
            else
            {
                Console.WriteLine("Congratulations! You can vote.");
            };
        }

        //7 - a method to check if an integer (from the user) is in the range -10 to 10.
        static public void WithinRange()
        {
            Console.Write("Please type in another number and I will determine if it is within -10 to 10 range:  ");
            var inputNumber = GetNum("\n");

            if (inputNumber >= -10 && inputNumber <= 10 )
            {
                Console.WriteLine("Yes! It is between -10 and 10. Thanks!");
            }
            else
            {
                Console.WriteLine($"{inputNumber} is out of target range.");
            };
        }

        //8 - a method to display the multiplication table (from 1 to 12) of a given integer
        static public void MultiplicationTable()
        {
            Console.Write("Here is a useful tool to help with multiplications. Please enter a number you would like multiplied by 1 through 12 here:  ");
            var n = GetNum("\n");

            for (int j = 1; j <= 12; ++j)
            {
                Console.WriteLine("{0} * {1} = {2}", n,j, n * j);
            }
        }



        // LET'S GET THIS SHOW STARTED:
        static void Main(string[] args)
        {
            // Runs a method that will print to the console all numbers 1000 through - 1000.
            Console.WriteLine("We will start with printing numbers from 1000 through -1000:\n");
            PrintNumbers();
            Console.WriteLine("\n\n");

            // Runs a method that will print to the console numbers 3 through 999 by 3 each time.
            Console.WriteLine("Next task was to print numbers from 3 through 999 incrementing by 3: \n");
            SkippingIn3();
            Console.WriteLine("\n\n");
            // Runs a method to accept two integers as parameters and check whether they are equal or not.
            PrintNumComparison();
            Console.WriteLine("\n\n");

            // Runs a method to check whether a given number is even or odd.
            PrintEvenOrOdd();
            Console.WriteLine();

            // Runs a method to check whether a given number is positive or negative.
            PositiveOrNegative();
            Console.WriteLine("\n\n");

            // Runs a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
            VotingAge();
            Console.WriteLine("\n\n");

            // Runs a method to check if an integer (from the user) is in the range -10 to 10.
            WithinRange();
            Console.WriteLine("\n\n");

            // Runs a method to display the multiplication table of a given integer
            MultiplicationTable();
            Console.WriteLine("\n\n");

            Console.WriteLine("Thank you for reviewing! Please let me know what you think :) ");
        }
    }
}
