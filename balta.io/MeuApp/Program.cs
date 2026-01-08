using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // convertendo tipos
            int inteiro = 100;
            float real = 20.5f;

            real = inteiro; // 100.0f conversão implicita
            inteiro = (int)real; //25 conversão explicita

            //inteiro = int.Parse(real);
            Convert.ToInt32(real);

            Console.WriteLine(Convert.ToBoolean(0.0));

            MeuMetodo("Teste");

            NomeCompleto("Luiz Ricardo", "Silva");

            // Value types - stack
            int x = 25;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 32;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // Reference Types - heap
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            // Struct
            Product mouse = new Product(1, "Mouse", 299.97, EProductType.Product);
            mouse.Id = 2;

            Console.WriteLine(mouse.Price);
        }

        // não é permitido métodos aninhados
        static void MeuMetodo(string param)
        {
            Console.WriteLine(param);
        }

        static void NomeCompleto(string nome, string sobrenome)
        {
            Console.WriteLine(nome + " " + sobrenome);
        }
    }

    // Struct
    //structs competem com classes, não podem estar dentro de uma
    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product() { }

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }

    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}