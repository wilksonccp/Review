using System;
using System.Globalization;
using ReviewStore;

namespace Exercicio1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            //ask to user the information about product
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome");
            p.Name = Console.ReadLine();
            Console.Write("Preço:");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            p.Amount = int.Parse(Console.ReadLine());

            //shou for user all informatios about product
            Console.WriteLine();
            Console.WriteLine($"Dados do produto {p}");

            // ask to user put the quantity of product to increse in stock
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser inseridos em estoque: ");
            int amt = int.Parse(Console.ReadLine());
            p.AddProdc(amt);

            //shou for user all informatios about product
            Console.WriteLine();
            Console.WriteLine($"Dados do produto atualizados:\n {p}");

            // ask to user put the quantity of product to remove in stock
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removidos em estoque: ");
            amt = int.Parse(Console.ReadLine());
            p.RemvProdc(amt);

            //shou for user all informatios about product
            Console.WriteLine();
            Console.WriteLine($"Dados do produto atualizados:\n {p}");

        }
    }
}
