using System;

public class ContaBancaria
{
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
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
        }
        else
        {
            Console.WriteLine("Saque não permitido.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Carlos");

        conta.Depositar(1000);
        conta.Sacar(250);

        Console.WriteLine($"Titular: {conta.Titular}");
        Console.WriteLine($"Saldo: R$ {conta.Saldo:F2}");

        // conta.Saldo = -5000;
        // Não compila porque Saldo possui private set.
    }
}
