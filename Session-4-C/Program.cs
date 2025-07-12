namespace Session_4_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            // Write a program that allows the user to insert an integer then print all numbers between 1 to that number
           Console.WriteLine("Enter an integer:");
           bool isValidInput = int.TryParse(Console.ReadLine(), out int number);
         if (isValidInput && number > 0) { 
               for (int i = 1; i <= number; i++)
               {
                   Console.Write($"{i},");
               }
            }
            #endregion

           
        }
    }
}
