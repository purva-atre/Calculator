using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int y = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("// Choose an option //");
            Console.WriteLine("1 - addition");
            Console.WriteLine("2 - subtration ");
            Console.WriteLine("3 - multification");
            Console.WriteLine("4 - division");
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine("// Result //");
                    Console.WriteLine(x + y);
                    break;
                case 2:
                    Console.WriteLine("// Result //");
                    Console.WriteLine(x - y);
                    break;
                case 3:
                    Console.WriteLine("// Result //");
                    Console.WriteLine(x * y);
                    break;
                case 4:
                    Console.WriteLine("// Result //");
                    Console.WriteLine(x / y);
                    break;
            }
            Console.ReadKey(true);
        }
        }
    }

