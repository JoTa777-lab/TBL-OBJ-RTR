using System;

public class Carro
{
    private string modelo;
    private int velocidadeAtual;

    public Carro(string modelo)
    {
        this.modelo = modelo;
        velocidadeAtual = 0;
    }

    public void Acelerar(int valor)
    {
        if (valor > 0)
        {
            velocidadeAtual += valor;
        }
    }

    public void Frear(int valor)
    {
        if (valor > 0)
        {
            velocidadeAtual -= valor;

            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
        }
    }

    public void ExibirVelocidade()
    {
        Console.WriteLine($"{modelo}: {velocidadeAtual} km/h");
    }
}

public class Program
{
    public static void Main()
    {
        Carro c = new Carro("Ferrari");

        c.Acelerar(50);
        c.ExibirVelocidade();

        c.Frear(30);
        c.ExibirVelocidade();

        c.Frear(50);
        c.ExibirVelocidade();
    }
}
