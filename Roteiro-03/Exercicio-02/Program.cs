using System;

public class Pessoa
{
    public string Nome { get; private set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa("João");

        pessoa.Idade = 20;
        pessoa.Email = "joao@email.com";

        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"Idade: {pessoa.Idade}");
        Console.WriteLine($"Email: {pessoa.Email}");

        pessoa.Idade = 21;

        Console.WriteLine("\nApós alterar a idade:");
        Console.WriteLine($"Idade: {pessoa.Idade}");

        // pessoa.Nome = "Carlos";
        // ERRO devido ao private set.
    }
}
