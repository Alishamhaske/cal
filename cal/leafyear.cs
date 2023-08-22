using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class leafyear
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("year is leaf year");
            }
            else
            {
                Console.WriteLine("non leaf year");
            }

        }
    }
}
