using System;
using System.Globalization;

class ContaBancaria
{
    public int NumeroConta { get; }
    public string NomeTitular { get; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial = 0.0)
    {
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
        Saldo = depositoInicial;
    }

    public void Deposito(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R${valor.ToString("F2", CultureInfo.InvariantCulture)} realizado com sucesso!");
    }

    public void Saque(double valor)
    {
        if (valor + 5.0 > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para saque!");
        }
        else
        {
            Saldo -= (valor + 5.0);
            Console.WriteLine($"Saque de R${valor.ToString("F2", CultureInfo.InvariantCulture)} realizado com sucesso!");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo atual da conta {NumeroConta}: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    public override string ToString()
    {
        return $"Número da Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}