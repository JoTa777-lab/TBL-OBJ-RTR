using System;

public class ContaBancaria
{
    private decimal saldo;

    // Somente leitura externa porque o saldo
    // deve ser modificado por operações controladas.
    public decimal Saldo
    {
        get
        {
            return saldo;
        }
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        conta.Depositar(1000);

        Console.WriteLine($"Saldo: R$ {conta.Saldo:F2}");

        // conta.Saldo = 1000;
        // ERRO: Saldo é somente leitura externamente.
    }
}
