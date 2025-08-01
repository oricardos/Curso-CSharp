using System;
using System.Globalization;
namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Produto p = new Produto("TV", 500.00, 0);
            // p.Nome = "P";
            // Console.WriteLine(p.Nome);
            // EXERCÍCIO

            int numero;
            string nome;
            double deposito, saque;
            char depositoInicial;
            ContaBancaria c;

            Console.Write("Entre o número da conta: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            depositoInicial = char.Parse(Console.ReadLine());

            if (depositoInicial == 's')
            {
                Console.Write("Entre um valor para depósito: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new ContaBancaria(numero, nome, valorInicial);

            }
            else
            {
                c = new ContaBancaria(numero, nome);
            }


            Console.WriteLine();
            Console.WriteLine($"Dados da conta: \n" + c);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine($"Dados da conta atualizados: \n" + c);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine($"Dados da conta atualizados: \n" + c);

        }
    }
}
