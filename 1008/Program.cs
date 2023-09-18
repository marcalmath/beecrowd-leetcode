using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, horas;
            double valor, salario;

            num = Convert.ToInt32(Console.ReadLine());
            horas = Convert.ToInt32(Console.ReadLine());
            valor = Convert.ToDouble(Console.ReadLine());

            salario = horas * valor;

            Console.WriteLine("NUMBER = "+num);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
