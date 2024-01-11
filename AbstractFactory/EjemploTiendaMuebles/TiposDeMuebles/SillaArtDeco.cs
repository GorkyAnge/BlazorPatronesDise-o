using EjemploTiendaMuebles.Interfaces;

namespace EjemploTiendaMuebles.TiposDeMuebles
{
    public class SillaArtDeco : ISilla
    {
        public void Sentarse() => Console.WriteLine("Sentarse en una silla Art Deco");
    }
}
