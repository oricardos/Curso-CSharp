using System;
using System.Globalization;

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

        // Datas
        var dataAtual = DateTime.Now;
        var pt = new System.Globalization.CultureInfo("pt-PT");
        var br = new System.Globalization.CultureInfo("pt-BR");
        var en = new System.Globalization.CultureInfo("en-US");
        var de = new System.Globalization.CultureInfo("de-DE");

        Console.WriteLine("Data");
        Console.WriteLine(dataAtual.ToString("D", pt));
        Console.WriteLine(dataAtual.ToString("D", de));
        Console.WriteLine(dataAtual.ToString("D", en));

        // Listas
        // Console.Clear();
        var myArr = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Arrays");
        Console.WriteLine("------=========------");
        Console.WriteLine(myArr[4]);

        Console.WriteLine("------=========------");

        for (var index = 0; index < myArr.Length; index++)
        {
            Console.WriteLine(myArr[index]);
        }

        foreach (var item in myArr)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Tratamento de erros");
        Console.WriteLine("------=========------");

        var newArr = new int[3] { 10, 20, 30 };

        try
        {
            for (var index = 0; index < 10; index++)
            {
                Console.WriteLine(newArr[index]);
            }
            Cadastrar("");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Aconteceu um erro: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Chegou ao fim");
        }


    }

    static void MeuMetodo(string param)
    {
        Console.WriteLine(param);
    }

    static void NomeCompleto(string nome, string sobrenome)
    {
        Console.WriteLine($"{nome} {sobrenome}");
    }

    static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            throw new Exception("O texto não pode ser nulo ou vazio");
    }
}
