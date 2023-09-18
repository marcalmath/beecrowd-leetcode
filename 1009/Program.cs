using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas;

            nome = Console.ReadLine();
            salario = Convert.ToDouble(Console.ReadLine());
            vendas = Convert.ToDouble(Console.ReadLine());

            salario += (15 * vendas) / 100;

            Console.WriteLine("TOTAL = R$ "+salario.ToString("F2"));
        }
    }
}
