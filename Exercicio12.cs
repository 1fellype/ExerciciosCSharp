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
            Console.Write("Digite um n�mero n�mero: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 9 && num < 20)
            {
                Console.WriteLine("O N�mero est� dentro da faixa.");
            }

            else
            {
                Console.WriteLine("N�mero fora da faixa.");
            }
        }
    }
}