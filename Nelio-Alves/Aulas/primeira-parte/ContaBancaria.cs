using System;
using System.Globalization;

namespace CursoCSharp
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Titular = nome;
        }
        public ContaBancaria(int numero, string nome, double valorInicial) : this(numero, nome)
        {
            Deposito(valorInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }



        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", "
            + "Titular: "
            + Titular
            + ", "
            + "Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}