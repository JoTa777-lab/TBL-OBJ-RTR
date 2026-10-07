using System;

public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area
    {
        get
        {
            return Largura * Altura;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Retangulo retangulo = new Retangulo();

        retangulo.Largura = 10;
        retangulo.Altura = 5;

        Console.WriteLine($"Área: {retangulo.Area}");

        retangulo.Largura = 20;

        Console.WriteLine($"Nova área: {retangulo.Area}");
    }
}
