using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class switch_vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your option");
            int option = Convert.ToChar(Console.ReadLine());



            switch (option)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("It is Vowel ");
                    break;
                default:
                    Console.WriteLine("It is Constant");
                    break;

            }

        }
    }
}
