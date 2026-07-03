using System;

public sealed class Carro
{
    public string Modelo { get; }
    public int Velocidade { get; private set; }

    public Carro(string modelo)
    {
        if (string.IsNullOrWhiteSpace(modelo))
            throw new ArgumentException("O modelo não pode ser vazio.", nameof(modelo));

        this.Modelo = modelo;
        this.Velocidade = 0;
    }

    public void Acelerar(int incremento)
    {
        if (incremento <= 0)
            throw new ArgumentOutOfRangeException(nameof(incremento), "O incremento deve ser maior que zero.");

        this.Velocidade += incremento;
        Console.WriteLine($"O carro {this.Modelo} acelerou e agora está a {this.Velocidade} km/h.");
    }

    public void Brecar(int decremento)
    {
        if (decremento <= 0)
            throw new ArgumentOutOfRangeException(nameof(decremento), "O decremento deve ser maior que zero.");

        this.Velocidade = Math.Max(0, this.Velocidade - decremento);
        Console.WriteLine($"O carro {this.Modelo} brecou e agora está a {this.Velocidade} km/h.");
    }
}

public static class Program
{
    public static void Main()
    {
        var carro1 = new Carro("Sedan");
        var carro2 = new Carro("Hetch");

        carro1.Acelerar(30);
        carro2.Acelerar(40);

        carro1.Brecar(10);
        carro2.Brecar(50);
    }
}








