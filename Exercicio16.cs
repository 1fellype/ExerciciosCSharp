using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Exercicio16
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Compras ---");
        Console.Write("Digite o valor da sua compra: ");
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("1 - Comum");
        Console.WriteLine("2 - Associado");
        Console.WriteLine("3 - VIP");
        Console.Write("Escolha a categoria: ");
        int categoria = Convert.ToInt32(Console.ReadLine());

        double desconto = 0;

        if (categoria == 1)
        {
            Console.WriteLine("O valor da sua compra é R$" + valor);
        }

        else if (categoria == 2)
        {
            desconto = valor - (valor * 0.10);

            Console.WriteLine("O valor da sua compra é R$" + desconto);
        }

        else if (categoria == 3)
        {
            desconto = valor - (valor * 0.20);
            Console.WriteLine("O valor da sua compra é R$" + desconto);
        }

        else
        {
            Console.WriteLine("O valor da sua compra é R$" + valor);
        }
    }
}