using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class switch_calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Addtion");
            Console.WriteLine("2.subtraction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            Console.WriteLine("5.modulos");

            Console.WriteLine("enter your option");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first NUmber" + a);
            Console.WriteLine("Second NUmber" + b);



            switch (option)
            {
                case 1:
                    int c = a + b;
                    Console.WriteLine("addtion"+c);
                    break;
                case 2:
                    int d = a - b;
                    Console.WriteLine("sub"+d);
                    break;
                case 3:
                    int mul=a*b;
                    Console.WriteLine("mul"+mul);
                    break;
                case 4:
                    int div = a / b;
                    Console.WriteLine("div"+div);
                    break;
                case 5:
                    int mod = a % b;
                    Console.WriteLine("mod"+mod);
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;

            }

        }
    }
}
