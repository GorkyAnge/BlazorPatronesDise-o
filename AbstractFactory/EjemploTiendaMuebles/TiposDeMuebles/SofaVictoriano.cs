using EjemploTiendaMuebles.Interfaces;

namespace EjemploTiendaMuebles.TiposDeMuebles
{
    public class SofaVictoriano : ISofa
    {
        public void Recostarse() => Console.WriteLine("Recostarse en un sofá victoriano");
    }
}
