using System;
using System.Collections.Generic;

abstract class Funcionario
{
    public string Nome { get; set; }

    public abstract decimal CalcularSalario();
}

class Gerente : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 8000;
    }
}

class Programador : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 6000;
    }
}

class Program
{
    static void Main()
    {
        Gerente gerente = new Gerente();
        gerente.Nome = "Carlos";

        Programador programador = new Programador();
        programador.Nome = "João";

        Console.WriteLine(
            $"Gerente: {gerente.Nome} - Salário: R$ {gerente.CalcularSalario():F2}"
        );

        Console.WriteLine(
            $"Programador: {programador.Nome} - Salário: R$ {programador.CalcularSalario():F2}"
        );

        List<Funcionario> funcionarios = new List<Funcionario>();

        funcionarios.Add(gerente);
        funcionarios.Add(programador);

        Console.WriteLine("\nFuncionários:");

        foreach (Funcionario funcionario in funcionarios)
        {
            Console.WriteLine(
                $"{funcionario.Nome} - R$ {funcionario.CalcularSalario():F2}"
            );
        }
    }
}
