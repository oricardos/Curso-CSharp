using System;
using System.Globalization;
using CursoCSharp.Entities;
using CursoCSharp.Entities.Enums;

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

            //Date.Aula();

            //Enums
            /*
             Order order = new Order
             {
                 Id = 1080,
                 Moment = DateTime.Now,
                 Status = OrderStatus.PendingPayment
             };

             System.Console.WriteLine(order);

             //Conversão de enums para string
             string txt = OrderStatus.PendingPayment.ToString();
             System.Console.WriteLine(txt);

             OrderStatus statusProcessing = OrderStatus.Processing;
             string statusProcessingString = Enum.GetName(statusProcessing);
             System.Console.WriteLine(statusProcessingString);

             // Conversão de String para Enum
             OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
             System.Console.WriteLine(os);
            */

            System.Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            System.Console.WriteLine("Enter worker Data");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();

            System.Console.Write("Level (Junior / MidLevel / Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            System.Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            System.Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Enter #{i} contract data: ");

                System.Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            System.Console.WriteLine();

            System.Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            System.Console.WriteLine($"Name: {worker.Name}");
            System.Console.WriteLine($"Department: {worker.Department.Name}");
            System.Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
