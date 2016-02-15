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
            int numberX = Convert.ToInt32(Console.ReadLine()); //Converts a specified value to a 32-bit signed integer.

            Console.WriteLine("Please Enter 2nd Number");
            int numberY = Convert.ToInt32(Console.ReadLine());

            int compute = Convert.ToInt32(Console.ReadLine());
            switch (compute)
            {
                case 1:
                    Console.WriteLine("Addition Total");
                    Console.WriteLine(numberX + numberY);
                    break;

                case 2:
                    Console.WriteLine("Minus Total");
                    Console.WriteLine(numberX - numberY);
                    break;


                case 3:
                    Console.WriteLine("Multiply Total");
                    Console.WriteLine(numberX * numberY);
                    break;

                case 4:
                    Console.WriteLine("Division Total");
                    Console.WriteLine(numberX / numberY);
                    break;
            }
            Console.ReadKey(true);
        }

        public static void AritheticOperators()
        {
            Console.WriteLine("Addition "+" + ");
            Console.WriteLine("Subtraction " + " - ");
            Console.WriteLine("Multiplication " + " * ");
            Console.WriteLine("Division " + " / ");
            Console.ReadLine();

            int compute = Convert.ToInt32(Console.ReadLine());
            switch (compute)
            {
                case 1:
                    Console.WriteLine("Addition Total");
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("Minus Total");
                    Console.WriteLine();
                    break;


                case 3:
                    Console.WriteLine("Multiply Total");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Division Total");
                    Console.WriteLine();
                    break;
            }
            Console.ReadKey(true);
        }

        //public static void Computation()
        //{
        //    int compute = Convert.ToInt32(Console.ReadLine());
        //    switch (compute)
        //    {
        //        case 1:
        //            Console.WriteLine("Addition Total");
        //            Console.WriteLine();
        //            break;

        //        case 2:
        //            Console.WriteLine("Minus Total");
        //            Console.WriteLine();
        //            break;


        //        case 3:
        //            Console.WriteLine("Multiply Total");
        //            Console.WriteLine();
        //            break;

        //        case 4:
        //            Console.WriteLine("Division Total");
        //            Console.WriteLine();
        //            break;
        //    }
        //    Console.ReadKey(true);
        //}


    }
}
