using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class convert_lower_upp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your character");
            char c = Convert.ToChar(Console.ReadLine());
            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("uppear case char " + c);
                c = (char)(c + 32);
                Console.WriteLine("after covert to lower case " + c);

            }
            else if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("lower case letter " + c);
                c = (char)(c - 32);
                Console.WriteLine("after convert to uppear case " + c);


            }
            else
            {
                Console.WriteLine("specail charter");

            }

        }
    }
}
