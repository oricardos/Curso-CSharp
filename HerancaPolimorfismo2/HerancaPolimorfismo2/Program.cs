using HerancaPolimorfismo2.Entities;
using System.Globalization;

Console.Write("Enter the number of Products: ");
int numberOfProducts = int.Parse(Console.ReadLine());

Product[] products = new Product[numberOfProducts];

// TODO USAR LIST<>
Product commonProduct = new Product();
Product usedProduct = new UsedProduct();
Product importedProduct = new ImportedProduct();

for (int i = 1; i <= numberOfProducts; i++)
{
    Console.WriteLine($"Product {i} data:");

    Console.Write("Common, used or imported (c/u/i)? ");
    char type = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (type == 'c')
    {
        // TODO LIST.ADD
        commonProduct = new Product(name, price);
    } else if (type == 'u')
    {
        Console.WriteLine("Manufactured Date: ");
        DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());
        // TODO LIST.ADD(NEW ...)
        usedProduct = new UsedProduct(name, price, manufacturedDate);
    } else if (type == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // TODO LIST.ADD(NEW ...)
        importedProduct = new ImportedProduct(name, price, customsFee);
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS");
Console.WriteLine(importedProduct.PriceTag());
Console.WriteLine(commonProduct.PriceTag());
Console.WriteLine(usedProduct.PriceTag());