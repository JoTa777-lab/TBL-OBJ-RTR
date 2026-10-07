using System;

class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
        andarAtual = 0;
    }

    public void Subir()
    {
        if (andarAtual < totalAndares)
        {
            andarAtual++;
        }
    }

    public void Descer()
    {
        if (andarAtual > 0)
        {
            andarAtual--;
        }
    }

    public void ExibirAndar()
    {
        Console.WriteLine("Andar atual: " + andarAtual);
    }
}

class Program
{
    static void Main()
    {
        Elevador e = new Elevador(10);

        e.Subir();
        e.Subir();
        e.ExibirAndar(); // Deve exibir 2

        e.Descer();
        e.ExibirAndar(); // Deve exibir 1

        e.Descer();
        e.Descer();
        e.ExibirAndar(); // Deve continuar em 0

        Console.WriteLine("\nTeste adicional:");

        Elevador elevadorTeste = new Elevador(3);

        elevadorTeste.Descer();
        elevadorTeste.ExibirAndar(); // Deve continuar em 0

        elevadorTeste.Subir();
        elevadorTeste.Subir();
        elevadorTeste.Subir();
        elevadorTeste.Subir();
        elevadorTeste.ExibirAndar(); // Deve continuar em 3
    }
}
