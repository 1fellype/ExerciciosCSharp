using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Criança? Adulto? Ou Idoso?---");
            Console.Write("Digite sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 0 && idade <= 12)
            {
                Console.Write("Você é uma criança.");
            }

            else if (idade >= 13 && idade <= 17)
            {
                Console.Write("Você é um adolescente.");
            }

            else if (idade >= 18 && idade <= 59)
            {
                Console.Write("Você é um adulto.");
            }

            else
            {
                Console.Write("Você é um idoso.");
            }
        }
    }
}
