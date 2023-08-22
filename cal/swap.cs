using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first number" + no1);
            Console.WriteLine("second number" + no2);
            int temp = 0;
            temp = no1;
            no1 = no2;
            no2 = temp;

            Console.WriteLine("swapping numbers");
            Console.WriteLine("first number" + no1);
            Console.WriteLine("second number" + no2);


        }
    }
}
