using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class greater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number1 ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number2 ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if(n1>n2)
            {
                Console.WriteLine("number 1 is grater ");

            }
            else
            {
                Console.WriteLine("number 2 is grater ");


            }


        }
    }
}
