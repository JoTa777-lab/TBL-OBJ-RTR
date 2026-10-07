using System;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Cargo}.");
    }

    public void ExibirSalario()
    {
        if (Cargo == "Gerente")
        {
            Console.WriteLine("Salário: R$ 10.000,00");
        }
        else if (Cargo == "Desenvolvedor")
        {
            Console.WriteLine("Salário: R$ 5.000,00");
        }
        else if (Cargo == "Estagiário")
        {
            Console.WriteLine("Salário: R$ 100,00");
        }
        else
        {
            Console.WriteLine("Cargo sem salário definido.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "João";
        p1.Idade = 30;
        p1.Cargo = "Gerente";

        Pessoa p2 = new Pessoa();
        p2.Nome = "Carlos";
        p2.Idade = 25;
        p2.Cargo = "Desenvolvedor";

        Pessoa p3 = new Pessoa();
        p3.Nome = "Ana";
        p3.Idade = 20;
        p3.Cargo = "Estagiário";

        p1.Apresentar();
        p1.ExibirSalario();

        Console.WriteLine();

        p2.Apresentar();
        p2.ExibirSalario();

        Console.WriteLine();

        p3.Apresentar();
        p3.ExibirSalario();
    }
}
