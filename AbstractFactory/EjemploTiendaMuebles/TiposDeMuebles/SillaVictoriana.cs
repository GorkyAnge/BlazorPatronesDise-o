using EjemploTiendaMuebles.Interfaces;

namespace EjemploTiendaMuebles.TiposDeMuebles
{
    public class SillaVictoriana : ISilla
    {
        public void Sentarse() => Console.WriteLine("Sentarse en una silla victoriana");
    }
}
