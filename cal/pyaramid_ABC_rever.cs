using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class pyaramid_ABC_rever
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("     A");
            Console.WriteLine("    AB");
            Console.WriteLine("   ABC");
            Console.WriteLine("  ABCD");
          */
            /*
                  A
                 AB
                ABC
               ABCD
              ABCDE

             */
            for (char i='A';i<='E';i++)
            {
                for(char k='E';k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(char j='A';j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
