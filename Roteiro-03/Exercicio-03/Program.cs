using System;

public class Produto
{
    private decimal preco;
    private string nome;

    public decimal Preco
    {
        get
        {
            return preco;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }

            preco = value;
        }
    }

    public string Nome
    {
        get
        {
            return nome;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }

            nome = value;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Produto produto = new Produto();

        try
        {
            produto.Nome = "Notebook";

            produto.Preco = 100;
            Console.WriteLine($"Preço: R$ {produto.Preco:F2}");

            produto.Preco = 250;
            Console.WriteLine($"Preço: R$ {produto.Preco:F2}");

            produto.Preco = -50;
        }
        catch (ArgumentException erro)
        {
            Console.WriteLine($"Erro: {erro.Message}");
        }
    }
}
