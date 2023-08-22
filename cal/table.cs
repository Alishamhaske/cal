using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class table
    {
        static void Main(string[] args)


        {
            Console.WriteLine("enter your number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n}*{i}= " + n * i);

            }
        }
    }
}


