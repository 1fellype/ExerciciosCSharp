using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Faixa 20 ---");
            Console.Write("Digite um número número: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 9 && num < 20)
            {
                Console.WriteLine("O Número está dentro da faixa.");
            }

            else
            {
                Console.WriteLine("Número fora da faixa.");
            }
        }
    }
}