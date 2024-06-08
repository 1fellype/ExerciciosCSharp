using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora Simples ---");
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação (+, -, X, /): ");
            string operacao = Console.ReadLine().ToLower();

            if (operacao == "+")
            {
                double soma = num1 + num2;
                Console.WriteLine("O resultado da operação de adição é " + soma);
            }

            else if (operacao == "-")
            {
                double minus = num1 + num2;
                Console.WriteLine("O resultado da subtração é " + minus);
            }

            else if (operacao == "x")
            {
                double vezes = num1 * num2;
                Console.WriteLine("O resultado da multiplicação é " + vezes);
            }

            else if (operacao == "/")
            {
                double divison = num1 / num2;
                Console.WriteLine("O resultado da divisão é " + divison);
            }

            else
            {
                Console.WriteLine("Comando inválido.");
            }
        }
    }
}
