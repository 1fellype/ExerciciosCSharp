using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Par ou Ímpar?---");
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.Write("O número é Par!");
            }

            else
            {
                Console.Write("O número é impar.");
            }

        }
    }
}
