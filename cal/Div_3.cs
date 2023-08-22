using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Div_3
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=30; i++)
            {
                if(i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
