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
       
        
        }
    }
}
