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
            Console.WriteLine("---Opera��es---");
            Console.Write("Digite sua nota: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 9)
            {
                Console.Write("Sua nota em conceito � A.");
            }

            else if (nota >= 7)
            {
                Console.Write("Sua nota em conceito � B.");
            }

            else if (nota >= 5)
            {
                Console.Write("Sua nota em conceito � C.");
            }

            else if (nota >= 3)
            {
                Console.Write("Sua nota em conceito � D.");
            }

            else
            {
                Console.Write("Sua nota em conceito � F.");
            }
        }
    }
}