using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManzanoExerciciosCSharp
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Dobro ---");
            Console.Write("Digite um número número: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 100)
            {
                Console.WriteLine("O número é maior que 100.");
            }

            else
            {
                double dobro = num * 2;
                Console.WriteLine("O dobro do seu número é " + dobro + ".");
            }
        }
    }
}