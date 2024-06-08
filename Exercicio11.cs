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
            Console.Write("Digite o primeiro n�mero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo n�mero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a opera��o (+, -, X, /): ");
            string operacao = Console.ReadLine().ToLower();

            if (operacao == "+")
            {
                double soma = num1 + num2;
                Console.WriteLine("O resultado da opera��o de adi��o � " + soma);
            }

            else if (operacao == "-")
            {
                double minus = num1 + num2;
                Console.WriteLine("O resultado da subtra��o � " + minus);
            }

            else if (operacao == "x")
            {
                double vezes = num1 * num2;
                Console.WriteLine("O resultado da multiplica��o � " + vezes);
            }

            else if (operacao == "/")
            {
                double divison = num1 / num2;
                Console.WriteLine("O resultado da divis�o � " + divison);
            }

            else
            {
                Console.WriteLine("Comando inv�lido.");
            }
        }
    }
}
