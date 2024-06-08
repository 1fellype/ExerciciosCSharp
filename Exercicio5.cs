using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Média---");
            Console.Write("Digite a primeira nota: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            int nota3 = int.Parse(Console.ReadLine());

            int media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.Write("Aluno aprovado :)");
            }

            else if (media >= 5)
            {
                Console.Write("Aluno em recuperação.");
            }

            else if (media < 5)
            {
                Console.Write("Aluno reprovado :(");
            }
        }
    }
}
