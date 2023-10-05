using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int valor_n = int.Parse(Console.ReadLine());
            double resultado=0 ;
            double sumatoria=0;

            for (int i = 1; i <= valor_n; i++)
            {
                resultado = (16.0 - i) / (3.0 * i);
                Console.WriteLine($"resultado: {resultado}");
                sumatoria += resultado;
            }
            Console.WriteLine(sumatoria);
            Console.ReadKey();
        }
    }
}
