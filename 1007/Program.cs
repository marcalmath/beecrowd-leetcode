﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diff;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            diff = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + diff);
        }
    }
}
