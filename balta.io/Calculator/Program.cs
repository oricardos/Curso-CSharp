static void Menu()
{
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("");
    Console.WriteLine("Selecione uma opção:");

    int calc = int.Parse(Console.ReadLine());

    switch (calc)
    {
        case 1:
            Soma();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Divisao();
            break;
        case 4:
            Multiplicacao();
            break;
        case 5:
            System.Environment.Exit(0);
            break;
        default:
            Menu();
            break;

    }
}

static void Soma()
{
    Console.Write("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());
    float resultado = v1 + v2;

    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Write("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 - v2;

    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Write("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 / v2;

    Console.WriteLine($"O resultado da divisão é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Write("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1 * v2;

    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.ReadKey();
    Menu();
}

Menu();