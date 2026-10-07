using System;

public class Pessoa
{
    public string Nome { get; set; }
}

public class Casa
{
    public Pessoa Morador { get; set; }

    public void ExibirMorador()
    {
        if (Morador != null)
        {
            Console.WriteLine(
                $"Morador da casa: {Morador.Nome}"
            );
        }
        else
        {
            Console.WriteLine("A casa não possui morador.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();

        pessoa.Nome = "João";

        Casa casa = new Casa();

        casa.Morador = pessoa;

        casa.ExibirMorador();
    }
}
