using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Exercicio15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- IMC ---");
        Console.Write("Digite o seu peso: ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Digite o sua altura: ");
        double altura = double.Parse(Console.ReadLine());

        double IMC = peso / (altura * altura);

        if (IMC < 18.5)
        {
            Console.WriteLine("Abaixo do peso.");
        }

        else if (IMC >= 18.5 && IMC <= 24.9)
        {
            Console.WriteLine("Peso normal.");
        }

        else if (IMC >= 25 && IMC < 29.9)
        {
            Console.WriteLine("Sobrepeso");
        }

        else if (IMC >= 30 && IMC < 34.9)
        {
            Console.WriteLine("Obesidade grau I");
        }

        else if (IMC >= 35 && IMC < 39.9)
        {
            Console.WriteLine("Obesidade grau II");
        }

        else if (IMC >= 40)
        {
            Console.WriteLine("Obesidade grau III");
        }

        else
        {
            Console.WriteLine("Invalído.");
        }
    }
}
