## 🧩 C# e .NET

### O que é C#?

**C# (C Sharp)** é uma linguagem de programação moderna, orientada a objetos, desenvolvida pela **Microsoft**.
Ela é fortemente tipada, elegante, segura e projetada para criar desde **aplicações desktop e web**, até **APIs, jogos (Unity)** e **aplicações móveis (Xamarin / MAUI)**.

C# é uma linguagem **compilada**, o que significa que o código é transformado em **IL (Intermediate Language)** e executado pela **Common Language Runtime (CLR)**, que faz parte da plataforma .NET.

---

### O que é .NET?

O **.NET** é uma **plataforma de desenvolvimento multiplataforma** criada pela Microsoft.
Ela oferece um ambiente completo com bibliotecas, ferramentas e um runtime para executar aplicações em diferentes sistemas operacionais (Windows, Linux e macOS).

> Em resumo: o **.NET** é o ecossistema, e o **C#** é a linguagem usada dentro dele.

---

### Principais Componentes do .NET

* **CLR (Common Language Runtime)** → Responsável por executar o código compilado e gerenciar recursos como memória e segurança.
* **BCL (Base Class Library)** → Conjunto de bibliotecas padrão com classes e métodos prontos para uso (ex: manipulação de arquivos, strings, datas, coleções, etc).
* **SDK / Runtime** → Ferramentas e ambiente necessários para compilar e rodar projetos .NET.
* **ASP.NET** → Framework para desenvolvimento de aplicações **web** e **APIs REST**.
* **Entity Framework Core (EF Core)** → ORM usado para interagir com bancos de dados relacionais usando objetos C#.

---

### 🧠 Exemplo simples em C#

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
        }
    }
}
```

📝 **Explicação:**

* `using System;` → Importa o namespace com classes básicas do .NET, como `Console`.
* `namespace HelloWorld` → Define o espaço de nomes do projeto.
* `class Program` → Classe principal do programa.
* `static void Main()` → Ponto de entrada da aplicação (método executado ao iniciar).

---

### ⚙️ Estrutura de um projeto .NET

Um projeto C# moderno normalmente segue essa estrutura:

```
MeuProjeto/
│
├── Program.cs
├── MeuProjeto.csproj
├── Models/
│   └── Usuario.cs
├── Services/
│   └── UsuarioService.cs
└── bin/ e obj/   (gerados automaticamente)
```

📦 O arquivo `.csproj` contém as dependências e configurações do projeto.

---

### 🚀 Criando e executando um projeto

```bash
# Criar um novo projeto console
dotnet new console -n MeuPrimeiroApp

# Entrar na pasta
cd MeuPrimeiroApp

# Executar
dotnet run
```

---

## 🧠 Programação Orientada a Objetos (POO)

A **Programação Orientada a Objetos (POO)** é um **paradigma de programação** que organiza o código em torno de **objetos**, em vez de funções ou procedimentos soltos.

Cada **objeto** representa algo do mundo real — como um usuário, um carro, um produto — e é definido por duas coisas:

* **Atributos** → As características do objeto (ex: nome, cor, preço).
* **Métodos** → Os comportamentos ou ações do objeto (ex: acelerar, salvar, calcular desconto).

O objetivo da POO é tornar o código **mais organizado, reutilizável e fácil de manter**.

---

### ⚙️ Os 4 pilares da POO

A POO é baseada em **quatro pilares principais**, que formam a base de qualquer sistema orientado a objetos:

#### 1. **Encapsulamento**

É o ato de **proteger os dados internos** de uma classe e expor apenas o que for necessário.
Isso evita que o código externo modifique o estado interno do objeto diretamente.

```csharp
public class ContaBancaria
{
    private decimal saldo; // atributo privado

    public void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public decimal ConsultarSaldo()
    {
        return saldo;
    }
}
```

> 🔒 O atributo `saldo` está protegido, e só pode ser alterado por meio dos métodos `Depositar()` e `ConsultarSaldo()`.

---

#### 2. **Herança**

Permite que uma classe **herde atributos e métodos** de outra.
Isso promove **reutilização de código** e facilita a manutenção.

```csharp
public class Veiculo
{
    public void Mover() => Console.WriteLine("Veículo em movimento");
}

public class Carro : Veiculo
{
    public void Buzinar() => Console.WriteLine("Biiip!");
}
```

> 🚗 A classe `Carro` herda o método `Mover()` da classe `Veiculo`.

---

#### 3. **Polimorfismo**

Significa **“muitas formas”**.
Permite que um mesmo método tenha **comportamentos diferentes**, dependendo do contexto ou da classe que o utiliza.

```csharp
public class Animal
{
    public virtual void Falar() => Console.WriteLine("Som genérico");
}

public class Cachorro : Animal
{
    public override void Falar() => Console.WriteLine("Au au!");
}

public class Gato : Animal
{
    public override void Falar() => Console.WriteLine("Miau!");
}
```

> 🐾 O método `Falar()` se comporta de forma diferente em cada classe filha.

---

#### 4. **Abstração**

É o processo de **simplificar a complexidade**, mostrando apenas o que é essencial.
Usamos classes e interfaces para **modelar o mundo real**, escondendo detalhes internos desnecessários.

```csharp
public abstract class Pagamento
{
    public abstract void Processar();
}

public class CartaoCredito : Pagamento
{
    public override void Processar() =>
        Console.WriteLine("Pagamento com cartão de crédito processado.");
}
```

> 💳 A classe `Pagamento` define o que deve ser feito, e `CartaoCredito` implementa como isso é feito.

---

### 🎯 Por que usar POO?

* Deixa o código **mais organizado** e próximo da forma como pensamos o mundo real.
* Facilita **reutilização e manutenção**.
* Favorece a **modularidade** (cada classe é responsável por algo específico).
* Torna o sistema **mais escalável e flexível**.

---

## 🧱 Classes e Objetos

Na Programação Orientada a Objetos (POO), **classes** e **objetos** são os **blocos fundamentais** da estrutura do código.

---

### 🧩 O que é uma Classe?

Uma **classe** é um **modelo (ou molde)** que define como um objeto deve ser.
Ela descreve os **atributos** (características) e **métodos** (comportamentos) que os objetos criados a partir dela terão.

> 💡 Pense em uma classe como o *“projeto”* de uma casa — e o objeto como a *“casa construída”*.

---

### 💡 Exemplo de Classe

```csharp
public class Pessoa
{
    // Atributos (características)
    public string Nome;
    public int Idade;

    // Método (comportamento)
    public void Falar()
    {
        Console.WriteLine($"{Nome} está falando.");
    }
}
```

> 🧠 A classe `Pessoa` define que toda pessoa tem um `Nome`, uma `Idade` e pode `Falar()`.

---

### 🧍‍♂️ O que é um Objeto?

Um **objeto** é uma **instância** (ou cópia concreta) de uma classe.
Ao criar um objeto, ele passa a existir na memória com seus próprios valores de atributos.

```csharp
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Idade = 25;
pessoa1.Falar();
```

📝 **Saída:**

```
João está falando.
```

> Aqui, `pessoa1` é um **objeto** da classe `Pessoa`.

---

### ⚙️ Criando e Usando Múltiplos Objetos

```csharp
Pessoa p1 = new Pessoa { Nome = "Ana", Idade = 30 };
Pessoa p2 = new Pessoa { Nome = "Carlos", Idade = 22 };

p1.Falar();
p2.Falar();
```

📝 **Saída:**

```
Ana está falando.
Carlos está falando.
```

> Cada objeto (`p1`, `p2`) tem seus próprios valores, mas compartilham a mesma estrutura definida pela classe `Pessoa`.

---

### 🧰 Classe vs Objeto — Resumo rápido

| Conceito   | Descrição                                                    | Exemplo              |
| ---------- | ------------------------------------------------------------ | -------------------- |
| **Classe** | É o modelo que define as características e comportamentos.   | `Pessoa`             |
| **Objeto** | É uma instância concreta da classe, com valores específicos. | `pessoa1`, `pessoa2` |

---

### 💬 Dica de boas práticas

* Use **nomes no singular** para classes (`Pessoa`, `Carro`, `Produto`).
* Use **letra maiúscula** inicial para classes e **minúscula** para objetos (convenção do C#).
* Cada classe deve ter uma **única responsabilidade** — isso torna o código mais limpo e fácil de manter.

---

## 🏗️ Construtores em C#

Um **construtor** é um **método especial** dentro de uma classe que é **executado automaticamente** quando um novo **objeto** é criado.

O principal objetivo do construtor é **inicializar os atributos** do objeto, garantindo que ele comece em um estado válido.

---

### 🧠 Características principais

* O **nome do construtor** é **igual ao nome da classe**.
* Ele **não possui tipo de retorno** (nem mesmo `void`).
* É **executado automaticamente** no momento da criação do objeto (`new`).
* Pode ser **sobrecarga** (você pode ter mais de um construtor com parâmetros diferentes).

---

### 💡 Exemplo de construtor simples

```csharp
public class Pessoa
{
    public string Nome;
    public int Idade;

    // Construtor
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
```

```csharp
Pessoa pessoa1 = new Pessoa("João", 25);
pessoa1.Apresentar();
```

📝 **Saída:**

```
Olá, meu nome é João e tenho 25 anos.
```

> 🔹 O construtor é chamado automaticamente quando fazemos `new Pessoa("João", 25)`.

---

### ⚙️ Construtor Padrão

Se nenhuma versão for definida, o C# cria automaticamente um **construtor padrão vazio**:

```csharp
public class Produto
{
    public string Nome;
    public double Preco;
}
```

```csharp
Produto p = new Produto();
p.Nome = "Notebook";
p.Preco = 3500.00;
```

> 💡 Como não há construtor definido, o compilador cria um por padrão.

---

### 🔄 Sobrecarga de Construtores

Podemos ter **vários construtores**, cada um aceitando diferentes parâmetros.
Isso permite flexibilidade na criação dos objetos.

```csharp
public class Carro
{
    public string Modelo;
    public string Cor;

    // Construtor 1
    public Carro(string modelo)
    {
        Modelo = modelo;
        Cor = "Branco"; // valor padrão
    }

    // Construtor 2
    public Carro(string modelo, string cor)
    {
        Modelo = modelo;
        Cor = cor;
    }

    public void Exibir()
    {
        Console.WriteLine($"Modelo: {Modelo}, Cor: {Cor}");
    }
}
```

```csharp
Carro carro1 = new Carro("Fusca");
Carro carro2 = new Carro("Civic", "Preto");

carro1.Exibir();
carro2.Exibir();
```

📝 **Saída:**

```
Modelo: Fusca, Cor: Branco
Modelo: Civic, Cor: Preto
```

---

### 🔒 Construtores privados

Um construtor pode ser **privado** — útil quando você quer **impedir que o código externo crie instâncias diretamente**.
Isso é comum em padrões como **Singleton**.

```csharp
public class Configuracao
{
    private static Configuracao instancia;

    private Configuracao() { } // construtor privado

    public static Configuracao Instancia
    {
        get
        {
            if (instancia == null)
                instancia = new Configuracao();

            return instancia;
        }
    }
}
```

> ⚙️ Assim, só existe **uma única instância** de `Configuracao` em todo o sistema.

---

### 💬 Boas práticas

* Inicialize **todos os atributos obrigatórios** no construtor.
* Prefira usar **sobrecarga** em vez de múltiplos métodos “Init()”.
* Use **construtores privados** quando quiser controlar a criação de instâncias.

---

## 🧭 Propriedades (Get e Set)

As **propriedades** em C# são uma forma **controlada e elegante** de acessar os **atributos privados** de uma classe.
Elas seguem o princípio do **encapsulamento**, permitindo **ler e alterar valores** de forma segura.

---

### 🧠 Conceito

* **`get`** → usado para **ler** o valor de um campo.
* **`set`** → usado para **atribuir** um valor ao campo.
* Por trás dos panos, as propriedades podem acessar variáveis privadas (chamadas *backing fields*).

---

### 💡 Exemplo básico com `get` e `set`

```csharp
public class Pessoa
{
    private string nome;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}
```

```csharp
Pessoa p = new Pessoa();
p.Nome = "João";           // usa o set
Console.WriteLine(p.Nome); // usa o get
```

📝 **Saída:**

```
João
```

> 🔍 Aqui, o campo `nome` continua **protegido**, mas pode ser acessado através da propriedade `Nome`.

---

### ⚙️ Auto-Properties (forma simplificada)

Na maioria dos casos, você não precisa declarar o campo privado manualmente.
O compilador cria isso automaticamente para você:

```csharp
public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}
```

```csharp
Produto prod = new Produto { Nome = "Monitor", Preco = 899.99 };
Console.WriteLine($"{prod.Nome} - R$ {prod.Preco}");
```

📝 **Saída:**

```
Monitor - R$ 899,99
```

> 💡 Forma mais moderna e usada no dia a dia com C#.

---

### 🔒 Propriedades com acesso restrito

Você pode controlar quem pode **ler ou alterar** os valores.
Por exemplo, permitir leitura pública mas escrita apenas dentro da classe:

```csharp
public class Usuario
{
    public string Nome { get; private set; }

    public Usuario(string nome)
    {
        Nome = nome;
    }
}
```

```csharp
Usuario u = new Usuario("Ana");
Console.WriteLine(u.Nome); // ok
// u.Nome = "Carlos"; ❌ Erro: set é privado
```

> 🔐 O `set` privado protege o valor contra alterações externas.

---

### 🧮 Propriedades com lógica interna

Propriedades também podem conter **regras de negócio** dentro dos blocos `get` e `set`.

```csharp
public class ContaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
        set
        {
            if (value < 0)
                Console.WriteLine("Saldo não pode ser negativo!");
            else
                saldo = value;
        }
    }
}
```

```csharp
ContaBancaria conta = new ContaBancaria();
conta.Saldo = -100; // inválido
conta.Saldo = 500;  // válido
Console.WriteLine(conta.Saldo);
```

📝 **Saída:**

```
Saldo não pode ser negativo!
500
```

> ⚙️ Isso permite validar e proteger os dados diretamente dentro da propriedade.

---

### 💬 Boas práticas

* Prefira **propriedades** no lugar de **atributos públicos**.
* Use **auto-properties** para classes simples.
* Utilize **restrições de acesso** (`private set`, `protected set`, etc.) quando necessário.
* Mantenha **lógica de validação** dentro das propriedades ou métodos específicos, nunca fora da classe.

---

## 🧮 Propriedades Calculadas

Uma **propriedade calculada** (ou *computed property*) é uma propriedade que **não armazena um valor diretamente**, mas **retorna um resultado baseado em outros atributos** da classe.

Ou seja, ela **calcula o valor sob demanda**, em vez de guardar um campo na memória.

---

### 💡 Exemplo simples

```csharp
public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    // Propriedade calculada
    public double Area
    {
        get { return Largura * Altura; }
    }
}
```

```csharp
Retangulo r = new Retangulo { Largura = 5, Altura = 3 };
Console.WriteLine($"Área: {r.Area}");
```

📝 **Saída:**

```
Área: 15
```

> 🔹 A propriedade `Area` é **calculada automaticamente** toda vez que for acessada, sem precisar de um campo `area` armazenado.

---

### ⚙️ Propriedades somente leitura (com expressão simplificada)

Para casos simples, você pode usar **“expression-bodied properties”**, uma sintaxe mais curta:

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public string NomeCompleto => $"{Nome} {Sobrenome}";
}
```

```csharp
Pessoa p = new Pessoa { Nome = "Maria", Sobrenome = "Oliveira" };
Console.WriteLine(p.NomeCompleto);
```

📝 **Saída:**

```
Maria Oliveira
```

> 💬 O `=>` indica que o valor é calculado e retornado diretamente.

---

### 💬 Quando usar propriedades calculadas

Use esse tipo de propriedade quando:

* O valor **depende de outros atributos**;
* Você quer **evitar redundância** (não armazenar o mesmo dado em mais de um lugar);
* Precisa garantir que o valor **esteja sempre atualizado**.

---

