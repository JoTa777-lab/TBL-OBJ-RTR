using System;

public class Produto
{
    public string Nome { get; private set; }
    public string Codigo { get; private set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEstoque { get; private set; }

    public bool EstoqueBaixo
    {
        get
        {
            return QuantidadeEstoque <= 5;
        }
    }

    public Produto(string nome, string codigo, decimal preco)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome obrigatório.");

        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentException("Código obrigatório.");

        if (preco < 0)
            throw new ArgumentException("Preço inválido.");

        Nome = nome;
        Codigo = codigo;
        Preco = preco;
        QuantidadeEstoque = 0;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEstoque += quantidade;
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= QuantidadeEstoque)
        {
            QuantidadeEstoque -= quantidade;
        }
        else
        {
            Console.WriteLine("Quantidade inválida.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Produto produto =
            new Produto("Notebook", "NB001", 3500);

        produto.AdicionarEstoque(20);

        Console.WriteLine(
            $"Estoque: {produto.QuantidadeEstoque}"
        );

        produto.RemoverEstoque(10);

        Console.WriteLine(
            $"Estoque: {produto.QuantidadeEstoque}"
        );

        Console.WriteLine(
            $"Estoque baixo: {produto.EstoqueBaixo}"
        );

        // produto.QuantidadeEstoque = 500;
        // ERRO devido ao private set.
    }
}
