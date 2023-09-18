using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, media;
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());

            media = (num1 * 2 + num2 * 3 + num3 * 5) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1"));
        }
    }
}
