﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    internal class Fact_for
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("factorial= "  + fact);
            Console.ReadLine();
        }
    }
}
