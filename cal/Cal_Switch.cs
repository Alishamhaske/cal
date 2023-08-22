using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Cal_Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a operator");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    Console.WriteLine("addtion " + (a + b));
                    break;
                case '-':
                    Console.WriteLine("Sub" + (a - b));
                    break;
                case '*':
                    Console.WriteLine("mul" + (a * b));
                    break;
                case '/':
                    Console.WriteLine("div" + (a / b));
                    break;
                case '%':
                    Console.WriteLine("mod" + (a % b));
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            Console.ReadLine();


        }
    }
}

