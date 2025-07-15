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
            /*
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
            */
            #endregion


            #region question6
            //Write a program to allow the user to enter a string and print the REVERSE of it.
            /*
            Console.WriteLine("please enter the string");
            string input = Console.ReadLine();
            string reversedInput = "";
            for (int i = input.Length - 1; i >= 0; i--) { 
            reversedInput += input[i];
            }
            Console.WriteLine($"reversed String: {reversedInput}");
            */
            #endregion

            #region question7
            //Write a program to allow the user to enter int and print the REVERSED of it.
            /*
            Console.WriteLine("please enter the int");
            bool validInput = int.TryParse(Console.ReadLine(), out int number);
           if (validInput)
            {
                string input = number.ToString();
                string reversedInput = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedInput += input[i];
                }
                Console.WriteLine($"reversed String: {reversedInput}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
             */

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


            #region question9
            // Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /*
            Console.Write("Enter a decimal number: ");
            int num = int.Parse(Console.ReadLine());
            string binary = "";

            while (num > 0)
            {
                binary = (num % 2) + binary;
                num /= 2;
            }

            Console.WriteLine("Binary: " + binary);
            */
            #endregion

            #region question10
            //Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
            //and determines whether these points lie on a single straight line.
            /*
            Console.WriteLine("please enter x1");
            bool isValidInputX1 = double.TryParse(Console.ReadLine(), out double x1);
            Console.WriteLine("please enter y1");
            bool isValidInputY1 = double.TryParse(Console.ReadLine(), out double y1);
            Console.WriteLine("please enter x2");
            bool isValidInputX2 = double.TryParse(Console.ReadLine(), out double x2);
            Console.WriteLine("please enter y2");
            bool isValidInputY2 = double.TryParse(Console.ReadLine(), out double y2);
            Console.WriteLine("please enter x3");
            bool isValidInputX3 = double.TryParse(Console.ReadLine(), out double x3);
            Console.WriteLine("please enter y3");
            bool isValidInputY3 = double.TryParse(Console.ReadLine(), out double y3);
            if(isValidInputX1 && isValidInputY1 && isValidInputX2 && isValidInputY2 && isValidInputX3 && isValidInputY3)
            {

                if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
                {
                    Console.WriteLine("Points are on a straight line.");
                }
                else
                {
                    Console.WriteLine("Points are NOT on a straight line.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
            */
            #endregion

            #region question11
            //Write a program that prints an identity matrix using for loop, in other words takes a value n
            //from the user and shows the identity table of size n * n.

            Console.WriteLine("please enter the number");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int n);
            if (isValidInput && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            }
            #endregion
        }
    }
}
