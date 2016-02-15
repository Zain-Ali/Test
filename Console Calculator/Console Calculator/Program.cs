using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program.UserInput();
            Program.AritheticOperators();
        }

        public static void UserInput()
        {
            Console.WriteLine("Please Enter 1st Number");
            int numberX;
            numberX= Convert.ToInt32(Console.ReadLine()); //Converts a specified value to a 32-bit signed integer.

            Console.WriteLine("Please Enter 2nd Number");
            int numberY;
            numberY = Convert.ToInt32(Console.ReadLine());

        }

        public static void AritheticOperators()
        {
            Console.WriteLine("Addition " + " + ");
            Console.WriteLine("Subtraction " + " - ");
            Console.WriteLine("Multiplication " + " * ");
            Console.WriteLine("Division " + " / ");
            Console.ReadLine();
        }
    }
}