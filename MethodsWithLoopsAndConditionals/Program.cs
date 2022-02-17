using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {

        //a method that will print to the console all numbers 1000 through -1000.
        static public void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; --i)
            {
                Console.Write($"* {i} *");
            }
        }

        //a method that will print to the console numbers 3 through 999 by 3 each time.
        static public void SkippingIn3()
        {
            for (int i = 3; i<1000; i+=3)
            {
                Console.Write($" - {i} -");
            }
        }

        //2 functions that accept two integers as parameters and check whether they are equal or not.

        static public void PrintNumComparison()

        {
            Console.Write("Hi! I bet you want to play with numbers after seeing so many of them on your screen! Let's compare two numbers of your choosing. Type in first whole number and press Enter:  ");
            var firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"Thanks! What other number should we compare it to (don't forget to press the magic button again):  ");
            var secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
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



        // a method to check whether a given number is even or odd
        
        static public void PrintEvenOrOdd()

        {
            Console.Write("I can determine if a number is even or odd. Type in a whole number and press enter:  ");
            var userInputNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userInputNum % 2 == 0)
                {
                Console.WriteLine($"{userInputNum} is an even number. That's all for our +- game. \n");
                }
            else
                {
                Console.WriteLine($"{userInputNum} is odd. That's all for our +- game.\n");
                };
        }

        // a method to check whether a given number is positive or negative

        static public void PositiveOrNegative()

        {
            Console.Write("I can determine if a number is positive or negative too. Type in a whole number and press enter:  ");
            var usersNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

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
                Console.WriteLine($"{usersNum} is positive.\n");
            };
        }


        // LET'S GET THIS SHOW STARTED:
        static void Main(string[] args)
        {
            // Runs a method that will print to the console all numbers 1000 through - 1000.
            Console.WriteLine("This is task # 1 - print out of numbers from 1000 through -1000:\n");
            PrintNumbers();
            Console.WriteLine("\n\n\n");

            // Runs a method that will print to the console numbers 3 through 999 by 3 each time.
            Console.WriteLine("This is task # 2 - print out of  numbers from 3 through 999 incrementing by 3: \n");
            SkippingIn3();
            Console.WriteLine("\n\n\n");
            // Runs a method to accept two integers as parameters and check whether they are equal or not.
            PrintNumComparison();
            Console.WriteLine("\n\n\n");

            // Runs a method to check whether a given number is even or odd.
            PrintEvenOrOdd();
            Console.WriteLine();

            // Runs a method to check whether a given number is positive or negative.
            PositiveOrNegative();
            Console.WriteLine("\n\n");

            //Runs a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!



        }
    }
}
