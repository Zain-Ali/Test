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
        }

        public static void UserInput()
        {
            Console.WriteLine("Please Enter 1st Number");
            int number = Convert.ToInt32(Console.ReadLine()); //Converts a specified value to a 32-bit signed integer.

            Console.WriteLine("Please Enter 2nd Number");
            int numner = Convert.ToInt32(Console.ReadLine());

        }


    }
}
