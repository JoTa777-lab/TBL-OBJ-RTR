using System;

class Pessoa
{
    public stribng Nome;
}

class Program
{
    static void Main()
    {
        
Pessoa p1 = new Pessoa();
p1.Nome = "Marcos";

Pessoa p2 = p1;

p2.Nome = "Joao";

Console.WriteLine(p1.Nome);

    }
}

