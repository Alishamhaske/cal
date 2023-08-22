using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class pyara_N
    {
        static void Main(string[] args)
        {
            //*    *
            //**   *
            //* *  *
            //*  * *
            //*   **
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j == 5|| i == j )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
}
