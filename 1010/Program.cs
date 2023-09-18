using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] compra1 = Console.ReadLine().Split(' ');
                int codigo1 = Convert.ToInt32(compra1[0]);
                int quantidade1 = Convert.ToInt32(compra1[1]);
                double valor1 = Convert.ToDouble(compra1[2]);

            string[] compra2 = Console.ReadLine().Split(' ');
                int codigo2 = Convert.ToInt32(compra2[0]);
                int quantidade2 = Convert.ToInt32(compra2[1]);
                double valor2 = Convert.ToDouble(compra2[2]);

            double total = (quantidade1 * valor1) + (quantidade2 * valor2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
