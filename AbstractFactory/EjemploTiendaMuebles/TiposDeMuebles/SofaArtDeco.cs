using EjemploTiendaMuebles.Interfaces;

namespace EjemploTiendaMuebles.TiposDeMuebles
{
    public class SofaArtDeco : ISofa
    {
        public void Recostarse() => Console.WriteLine("Recostarse en un sofá Art Deco");
    }
}
