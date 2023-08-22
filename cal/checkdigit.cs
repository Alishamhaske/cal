using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class checkdigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter character");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
            {
                Console.WriteLine("It is character");
            }
            else if ((c <= 48 && c >= 57))
            {
                Console.WriteLine("it is Digit");
            }
            else
            {
                Console.WriteLine("Special character");
            }



        }
    }
}
