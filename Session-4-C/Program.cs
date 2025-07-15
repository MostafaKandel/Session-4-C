using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Session_4_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            // Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            /*
             Console.WriteLine("Enter an integer:");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int number);
          if (isValidInput && number > 0) { 
                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{i},");
                }
             }
            */
            #endregion

            #region question2
            // Write a program that allows the user to insert an integer then 
            //print a multiplication table up to 12.
            /*
            Console.Write("please enter an integer ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int number);
            if (isValidInput )
            {
                for(int i= 1; i <= 12; i++)
                {
                    int result = number * i;
                    Console.WriteLine($"{result} ");
                }
            }
            */
            #endregion

            #region question3
            // Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*
            Console.Write("please enter an integer ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int number);
            if (isValidInput)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                    
                }
            }
            */

            #endregion

            #region question4
            //Write a program that takes two integers then prints the power.
            /*
            Console.Write("please enter first integer ");
            bool isValidInput1 = int.TryParse(Console.ReadLine(), out int number1);
            Console.Write("please enter second integer ");
            bool isValidInput2 = int.TryParse(Console.ReadLine(), out int number2);

            if (isValidInput1 && isValidInput2)
            {
                int result = 1;
                for (int i = 1; i <= number2; i++)
                {
                   result *= number1;

                }
                Console.WriteLine($"output {result}");
            }
            */
            #endregion

            #region question5
            //Write a program to enter marks of five subjects and calculate total, average and percentage.

            Console.WriteLine("please enter the grades of five subjects");
            int total = 0;
            for (int i = 1; i < 6; i++) {
                Console.Write("Subject " + i + ": ");
                total += int.Parse(Console.ReadLine());
            }

            double average = total / 5;
            double percentage = average;
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine($"precentage= {percentage}%");
            #endregion


            #region question8
            //Write a program in C# Sharp to find prime numbers within a range of numbers.
            /*
            Console.Write("Enter the starting number of the range: ");
            bool isValidInputStart = int.TryParse(Console.ReadLine(), out int startNumber);
            Console.Write("Enter the ending number of the range: ");
            bool isValidInputEnd = int.TryParse(Console.ReadLine(), out int endNumber);
            if (isValidInputEnd && isValidInputStart)
            {
                for (int number = startNumber; number <= endNumber; number++)
                {
                    if (number <= 1)
                        continue;

                    bool isPrime = true;

                    if (number == 2)
                    {
                        Console.WriteLine(number);
                        continue;
                    }

                    if (number % 2 == 0)
                        continue;

                    int boundary = (int)Math.Sqrt(number);

                    for (int i = 3; i <= boundary; i += 2)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                        Console.WriteLine(number);
                }
            }
            else
            {
                               Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        */

            #endregion


        }
    }
}
