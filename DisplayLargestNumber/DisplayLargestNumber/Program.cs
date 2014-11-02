using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Program prompts for two numbers and displays the largest number of the two.*/


namespace DisplayLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double number1 = 0.0;
            double number2 = 0.0;
            bool inputCorrect = true;

            //display purpose of program.
            Console.WriteLine("Program prompts for two numbers and displays the largest of the two.");

            //prompt for first number.
            do
            {
                try
                {
                    Console.Write("Please enter first number: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    inputCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Input Error! Please enter a number.");
                    inputCorrect = false;
                }
            } while (!inputCorrect);

            //prompt for second number.
            do
            {
                try
                {
                    Console.Write("Please enter second number: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    inputCorrect = true;
                }
                catch
                {
                    Console.WriteLine("Input Error! Please enter a number.");
                    inputCorrect = false;
                }
            } while (!inputCorrect);

            //compare input and display result.
            if (number1 == number2)
            {
                Console.WriteLine("The two numbers are equal.");
            }
            else if (number1 > number2)
            {
                Console.Write("The largest number is: ");
                Console.WriteLine(number1.ToString());
            }
            else
            {
                Console.Write("The largest number is: ");
                Console.WriteLine(number2.ToString());
            }

            Console.WriteLine("Thanks for using the program!");
        }
    }
}
