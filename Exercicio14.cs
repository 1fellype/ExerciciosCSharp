using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
    internal class Exercicio14
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Raiz ou Quadrado ---");
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            double raiz = 0;
            double quadrado = 0;
           
            if (num > 0)
            {
                raiz = Math.Sqrt(num);
                Console.WriteLine("A raiz quadrada do número é " + raiz + ".");
            }
           
            else
            {
                quadrado = num * num;
                Console.WriteLine("O quadrado do número é " + quadrado + ".");
            }
        }
    }
}