using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Testing_Fibonacci_with_FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // FibonacciSeries();
            Console.WriteLine();
            FizzBuzz();
            Console.ReadLine();
        }

        public static void FibonacciSeries()
        {
            int FirstNumber = 0;
            int SecondNumber = 1;
            int Total = 0;
            int UserInput;

            Console.WriteLine("Please Enter a Fib number?");
            UserInput = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The number you entered is " + UserInput);
            Thread.Sleep(5000);


            for (int i = 0; i < UserInput; i++)
            {
                Total = FirstNumber + SecondNumber;
                FirstNumber = SecondNumber;
                SecondNumber = Total;
                Console.WriteLine("Fibonacci " + SecondNumber);
            }
        }

        public static void FizzBuzz()
        {

            int UserInput;

            Console.WriteLine("Please Enter a FizzBuzz number?");
            UserInput = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The number you entered is " + UserInput);
            Thread.Sleep(5000);

            for (int i = 1; i <= UserInput; i++)
            {
                bool Fizz = i % 3 == 0;
                bool Buzz = i % 5 == 0;

                if (Fizz && Buzz)
                {
                    Console.WriteLine( i + " FizzBuzz");
                }

                else if (Fizz)
                {
                    Console.WriteLine(i + " Fizz");
                }

                else if (Buzz)
                {
                    Console.WriteLine(i + " Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
