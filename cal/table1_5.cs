﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class table1_5
    {
        static void Main(string[] args)
        {
           
            for(int i=1;i<=5;i++)
            {

                for(int j=1;j<=10;j++)
                {
                    Console.WriteLine(i * j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
