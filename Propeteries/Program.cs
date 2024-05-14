using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o número da conta:");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o nome do titular:");
        string nomeTitular = Console.ReadLine();

        Console.WriteLine("Haverá depósito inicial? (s/n):");
        char resposta = char.Parse(Console.ReadLine());

        double depositoInicial = 0.0;
        if (resposta == 's' || resposta == 'S')
        {
            Console.WriteLine("Informe o valor do depósito inicial:");
            depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        ContaBancaria conta = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);

        Console.WriteLine();
        Console.WriteLine("Dados da Conta:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.WriteLine("Realize um depósito:");
        double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(valorDeposito);

        Console.WriteLine();
        Console.WriteLine("Dados Atualizados da Conta:");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.WriteLine("Realize um saque:");
        double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(valorSaque);

        Console.WriteLine();
        Console.WriteLine("Dados Atualizados da Conta:");
        Console.WriteLine(conta);
    }
}