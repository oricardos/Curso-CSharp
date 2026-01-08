using System;

enum EProductType
{
    Product = 1,
    Service = 2
}

struct Product
{
    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

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

class Program
{
    static void Main()
    {
        Console.WriteLine(Convert.ToBoolean(0.0));

        MeuMetodo("Teste");
        NomeCompleto("Luiz Ricardo", "Silva");

        int x = 25;
        int y = x;

        x = 32;

        var arr = new string[2];
        arr[0] = "Item 1";

        var arr2 = arr;

        arr[0] = "Item 2";

        Product mouse = new Product(1, "Mouse", 299.97, EProductType.Product);
        mouse.Id = 2;

        var price = 10.2;
        var text = $@"O preço do produto
é de {price} apenas na promoção";

        Console.WriteLine(text);

        var compareText = "Testando";
        Console.WriteLine(compareText.CompareTo("Testando"));
    }

    static void MeuMetodo(string param)
    {
        Console.WriteLine(param);
    }

    static void NomeCompleto(string nome, string sobrenome)
    {
        Console.WriteLine($"{nome} {sobrenome}");
    }
}
