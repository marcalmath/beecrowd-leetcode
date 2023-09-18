using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double m = 0;

            m = (num1 * 3.5 + num2 * 7.5) / 11;

            Console.WriteLine("MEDIA = "+m.ToString("F5"));

        }
    }
}
