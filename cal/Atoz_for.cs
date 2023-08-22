using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Atoz_for
    {
        static void Main(string[] args)
        {
            for( int i=0;i<26;i++)

            {
                Console.Write(Convert.ToChar(i + (int)'A') + " ");
            }


            Console.ReadLine();
        }
        
    }
}
