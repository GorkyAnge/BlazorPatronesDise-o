using EjemploTiendaMuebles.Interfaces;

namespace EjemploTiendaMuebles.TiposDeMuebles
{
    public class SofaModerno : ISofa
    {
        public void Recostarse() => Console.WriteLine("Recostarse en un sofá moderno");
    }
}
