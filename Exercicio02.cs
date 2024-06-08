using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Positivo? Negativo? Ou Zero?---");
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                Console.Write("O número é Positivo!");
            }

            else if (num1 == 0)
            {
                Console.Write("O número é Zero.");
            }

            else
            {
                Console.WriteLine("O número é negativo.");
            }
        }
    }
}

