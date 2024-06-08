using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanoExerciciosCSharp
{
	internal class Exercicio3
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("---Qual deles é o maior?---");
			Console.Write("Digite um número: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.Write("Digite outro número: ");
			int num2 = int.Parse(Console.ReadLine());

			if (num1 > num2)
			{
				Console.Write("O primeiro número (" + num1 + ") é o maior.");
			}

			else
			{
				Console.Write("O segundo número (" + num2 + ") é o maior.");
			}
		}
	}
}
