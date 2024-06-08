using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Ano Bissexto---");
            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0 || ano % 400 == 0)
            {
                Console.Write("O ano " + ano + " é bissexto.");
            }

            else
            {
                Console.Write("O ano " + ano + " não é bissexto.");
            }
        }
    }
}
