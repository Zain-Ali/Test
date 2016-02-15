using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    public class Computation
    {
        public void ComputationTotal()
        {
            
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

    }
}
