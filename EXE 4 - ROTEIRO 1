using System;

public class ContaBancaria
{
    public string Titular;
    public int NumeroConta;
    public decimal Saldo;

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado.");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Conta: {NumeroConta}");
        Console.WriteLine($"Saldo: R$ {Saldo:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria();
        conta1.Titular = "João";
        conta1.NumeroConta = 1001;
        conta1.Saldo = 0;

        ContaBancaria conta2 = new ContaBancaria();
        conta2.Titular = "Maria";
        conta2.NumeroConta = 1002;
        conta2.Saldo = 0;

        conta1.Depositar(1000);
        conta1.Sacar(250);
        conta1.ExibirSaldo();

        Console.WriteLine();

        conta2.Depositar(2000);
        conta2.Sacar(500);
        conta2.ExibirSaldo();
    }
}
