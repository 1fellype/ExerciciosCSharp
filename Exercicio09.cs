using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Categoria = Produto---");
            Console.Write("Digite o código do Produto: ");
            int codigo = int.Parse(Console.ReadLine());

            if (codigo >= 1 && codigo < 10)
            {
                Console.Write("O alimento é não-perecível");
            }

            else if (codigo >= 11 && codigo < 20)
            {
                Console.Write("O alimento é perecível");
            }

            else if (codigo >= 21 && codigo < 30)
            {
                Console.Write("O produto é de Vestuário.");
            }

            else if (codigo >= 31 && codigo < 40)
            {
                Console.Write("O produto é de Eletrônico.");
            }

            else
            {
                Console.Write("Código inválido.");
            }
        }
    }
}