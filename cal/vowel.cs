using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your character ");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("character is " + c);
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("character is Vowel " + c);
            }
            else
            {
                Console.WriteLine("Character is constant " + c);
            }





        }
    }
}
