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
			Console.WriteLine("---Qual deles � o maior?---");
			Console.Write("Digite um n�mero: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.Write("Digite outro n�mero: ");
			int num2 = int.Parse(Console.ReadLine());

			if (num1 > num2)
			{
				Console.Write("O primeiro n�mero (" + num1 + ") � o maior.");
			}

			else
			{
				Console.Write("O segundo n�mero (" + num2 + ") � o maior.");
			}
		}
	}
}
