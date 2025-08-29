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
            /*
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
            */

            //ArrayClass.Executar();
            /*int n = int.Parse(Console.ReadLine());
             Product[] vect = new Product[n];

             for (int i = 0; i < n; i++)
             {
                 string name = Console.ReadLine();
                 double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                 vect[i] = new Product { Name = name, Price = price };
             }

             double sum = 0.0;

             for (int i = 0; i < n; i++)
             {
                 sum += vect[i].Price;
             }

             double avg = sum / n;

             Console.WriteLine("Média " + avg.ToString("F2", CultureInfo.InvariantCulture));*/

            /*Student[] rooms = new Student[10];
            Console.Write("How many rooms will be rented? ");
            int rentedRooms = int.Parse(Console.ReadLine());

            for (int i = 0; i < rentedRooms; i++)
            {
                Console.WriteLine("Rent #" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                rooms[room] = new Student { Name = name, Email = email };
            }

            Console.WriteLine("");

            Console.WriteLine("Busy rooms");

            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(i + ": " + rooms[i].Name + ", " + rooms[i].Email);
                }
            }*/


            // int s1 = Calculator.Sum(10, 20, 30);
            // int a = 10;
            // int quadruple;
            // Calculator.Triple(ref a);
            // Calculator.Quadruple(a, out quadruple);
            // Console.WriteLine(a);
            // Console.WriteLine(quadruple);

            ListAula.Exercise();
        }
    }
}
