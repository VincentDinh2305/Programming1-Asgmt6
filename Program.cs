using System;
    /*
     * Name: DINH HOANG VIET PHUONG
     * Date: April 09, 2021
     * Student number: 301123263
     */
namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Menu();           
        }
        #region DisplayMenu
        private static void DisplayMenu()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("   Calculation Menu");
            Console.WriteLine("3) Calculate Sum");
            Console.WriteLine("4) Calculate Sum of Squares");
            Console.WriteLine("5) Calculate Sum of Cubes");
            Console.WriteLine("0) To Exit");
            Console.WriteLine();
            Console.Write("Enter the number that corresponds to your choice: ");

        }
        #endregion

        #region Menu
        private static void Menu()
        {
            int choice;
            do
            {
                Program.DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());               
                if (choice == 3)
                {
                    Program.CalculateSum();
                }
                else if (choice == 4)
                {
                    Program.CalculateSumOfSquares();
                }
                else if (choice == 5)
                {
                    Program.CalculateSumOfCubes();
                }              
                else if (choice != 0)
                {
                    Console.WriteLine("Error: Invalid input");
                }
            } while (choice != 0);
        }
        #endregion

        #region CalculateSum
        private static void CalculateSum()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.Write("How many numbers: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int x = 0; x < number; x++)
            {
                Console.Write($"Please enter value #{x + 1}: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"The sum of {number} number(s) is {sum}");
            Console.WriteLine("--------------------------------------------------");
        }
        #endregion

        #region CalculateSumOfSquares
        private static void CalculateSumOfSquares()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.Write("How many numbers: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0, squares = 0;
            for (int x = 0; x < number; x++)
            {
                Console.Write($"Please enter value #{x + 1}: ");
                int a = Convert.ToInt32(Console.ReadLine());
                squares = a * a;
                Console.WriteLine($"Number is {a} and squares of {a} is {squares}");
                sum += squares;
            }
            Console.WriteLine($"The sum of {number} squares is {sum}");
            Console.WriteLine("--------------------------------------------------");
        }
        #endregion

        #region CalculateSumOfCubes
        private static void CalculateSumOfCubes()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.Write("How many numbers: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0, squares = 0;
            for (int x = 0; x < number; x++)
            {
                Console.Write($"Please enter value #{x + 1}: ");
                int a = Convert.ToInt32(Console.ReadLine());
                squares = a * a * a;
                Console.WriteLine($"Number is {a} and squares of {a} is {squares}");
                sum += squares;
            }
            Console.WriteLine($"The sum of {number} squares is {sum}");
            Console.WriteLine("--------------------------------------------------");
        }
        #endregion
    }
}
