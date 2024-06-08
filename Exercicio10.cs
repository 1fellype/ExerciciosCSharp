using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Operações---");
            Console.Write("Digite sua nota: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 9)
            {
                Console.Write("Sua nota em conceito é A.");
            }

            else if (nota >= 7)
            {
                Console.Write("Sua nota em conceito é B.");
            }

            else if (nota >= 5)
            {
                Console.Write("Sua nota em conceito é C.");
            }

            else if (nota >= 3)
            {
                Console.Write("Sua nota em conceito é D.");
            }

            else
            {
                Console.Write("Sua nota em conceito é F.");
            }
        }
    }
}