using SimuladorDeCorrida.Models;

namespace SimuladorDeCorrida;

public static class Program
{
    public static void Main()
    {
        var carro1 = new Carro("Sedan");
        var carro2 = new Carro("Hatch");

        carro1.Acelerar(30);
        carro2.Acelerar(40);

        carro1.Brecar(10);
        carro2.Brecar(50);
    }
}
