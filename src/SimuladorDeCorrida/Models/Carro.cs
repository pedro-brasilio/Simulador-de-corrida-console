namespace SimuladorDeCorrida.Models;

/// <summary>
/// Representa um carro da simulação, com um modelo e controle de velocidade.
/// </summary>
public sealed class Carro
{
    public string Modelo { get; }
    public int Velocidade { get; private set; }

    public Carro(string modelo)
    {
        if (string.IsNullOrWhiteSpace(modelo))
            throw new ArgumentException("O modelo não pode ser vazio.", nameof(modelo));

        Modelo = modelo;
        Velocidade = 0;
    }

    public void Acelerar(int incremento)
    {
        if (incremento <= 0)
            throw new ArgumentOutOfRangeException(nameof(incremento), "O incremento deve ser maior que zero.");

        Velocidade += incremento;
        Console.WriteLine($"O carro {Modelo} acelerou e agora está a {Velocidade} km/h.");
    }

    public void Brecar(int decremento)
    {
        if (decremento <= 0)
            throw new ArgumentOutOfRangeException(nameof(decremento), "O decremento deve ser maior que zero.");

        Velocidade = Math.Max(0, Velocidade - decremento);
        Console.WriteLine($"O carro {Modelo} brecou e agora está a {Velocidade} km/h.");
    }
}
