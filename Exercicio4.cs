using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Tri�ngulo---");
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor1 < valor2 + valor3 && valor2 < valor1 + valor3 && valor3 < valor1 + valor2)
            {
                Console.Write("� um tri�ngulo v�lido.");
            }

            else
            {
                Console.Write("Os valores n�o formam um tri�ngulo.");
            }
        }
    }
}