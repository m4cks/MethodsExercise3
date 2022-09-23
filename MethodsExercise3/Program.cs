using System;

namespace MethodsExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LUKEWARM SECTION

            //1 - Numbers 1000 through -1000
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            //2 - Numbers 3 through 999 by 3's
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }


            var number = 4;
            //3 - Method to check equality between two integers
            Console.WriteLine($"Is {number} equal to 5? " + IntegerEqualityCheck(number, 5));

            //4 - Check if number is even or odd
            Console.WriteLine($"Is {number} even or odd? " + EvenOrOdd(number));

            //5 - Check if number is positive or negative
            Console.WriteLine($"Is {number} positive or negative? " + PosOrNeg(number));

            //6 - Determine the age of user and if they can vote
            Console.WriteLine("How old are you? We're trying to see if you're old enough to vote.");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            bool canVote = age >= 18;
            if (canVote)
                Console.WriteLine("Yep! Hi voter.");
            else
                Console.WriteLine("Nope! Sorry kid.");


            //HEATIN UP SECTION

            //1 - Take input and check if between -10 and 10
            Console.WriteLine("Let's see if you give me a number between -10 and 10 or not.");
            int userInput;
            int.TryParse(Console.ReadLine(), out userInput);
            if (userInput >= -10 && userInput <= 10)
                Console.WriteLine("Nice, in the range!");
            else
                Console.WriteLine("Nope, out of range!");

            //2 - Check given integer's multiplication table 1 through 12

            Console.WriteLine("Time to practice your multiplication tables! Gimme a number.");
            var multiplicationInput = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {multiplicationInput} = " + i*multiplicationInput);
            }

            Console.WriteLine("All done! :)");
        }


        public static string PosOrNeg(int num)
        {
            if(num > 0)
            {
                return "Positive";
            } else if(num == 0)
            {
                return "Not Negative Nor Positive";
            } 
            else 
            {
                return "Negative";
            }
        }
        public static string EvenOrOdd(int num)
        {
            if(num%2 == 0)
            {
                return "Even";
            } else
            {
                return "Odd";
            }
        }

        public static bool IntegerEqualityCheck(int num1, int num2)
        {
            return num1 == num2;
        }
    }
}
