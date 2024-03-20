using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num1 = 33;
            Console.WriteLine($"Hello, World! num = {num1}");
            string stringnum2 = Console.ReadLine();
            Console.WriteLine($"stringnum2 ={stringnum2}");
            Boolean a = Int32.TryParse(stringnum2, out num1);
            if (a)
            {
                Console.WriteLine("Convert string to int32 Success");
            }
            else
            {
                Console.WriteLine("Cannot convert string to int32");
            }
            switch (num1)
            {
                case 77:
                    Console.WriteLine($"stringnum2 ={stringnum2}");
                    break;
                default:
                    Console.WriteLine("value is different");
                    break;            
            }
            try
            {
                int num_var = Convert.ToInt32(stringnum2);
                System.Console.WriteLine(num_var);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid String");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The string cannot fit in 32 bit value");
            }

            Console.ReadKey();
        }
    }
}