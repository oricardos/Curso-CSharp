
using System;
using System.Globalization;
namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            p.SetNome("P");
            Console.WriteLine(p.GetNome());
        }
    }
}