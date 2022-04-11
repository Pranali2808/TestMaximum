using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Testmaximum  program");
            TestMax maximum = new TestMax();
            Console.WriteLine("Select from given  below.....\n1. Max in Three Integers \n2 Max in Three Floats \n3. Max in string \n4. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {

                case 1:
                    Console.WriteLine("Enter first integer");
                    int intNum1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    int intNum2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer");
                    int intNum3 = Convert.ToInt32(Console.ReadLine());
                    int intMax = maximum.TestMaximum(intNum1, intNum2, intNum3);
                    if (intMax == 0)
                    {
                        Console.WriteLine("Two or Three numbers have equal value");
                    }
                    else
                        Console.WriteLine("Maximum out of given numbers {0} {1} & {2} is {3}", intNum1, intNum2, intNum3, intMax);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();
        }
    }
}









