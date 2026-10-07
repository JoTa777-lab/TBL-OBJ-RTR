using System;

public class Veiculo
{
    public string Marca;
    public string Modelo;
    public int NumeroDeRodas;

    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Número de rodas: {NumeroDeRodas}");
    }
}

public class Carro : Veiculo
{
    public int NumeroDePortas;
}

public class Moto : Veiculo
{
    public bool PossuiBagageiro;
}

public class Program
{
    public static void Main()
    {
        Carro carro = new Carro();

        carro.Marca = "Toyota";
        carro.Modelo = "Corolla";
        carro.NumeroDeRodas = 4;
        carro.NumeroDePortas = 4;

        Console.WriteLine("=== CARRO ===");
        carro.ExibirDados();
        Console.WriteLine($"Número de portas: {carro.NumeroDePortas}");

        Moto moto = new Moto();

        moto.Marca = "Honda";
        moto.Modelo = "CB 500";
        moto.NumeroDeRodas = 2;
        moto.PossuiBagageiro = true;

        Console.WriteLine("\n=== MOTO ===");
        moto.ExibirDados();
        Console.WriteLine(
            $"Possui bagageiro: {moto.PossuiBagageiro}"
        );
    }
}
