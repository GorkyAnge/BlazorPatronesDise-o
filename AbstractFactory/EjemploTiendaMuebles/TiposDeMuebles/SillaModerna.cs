using EjemploTiendaMuebles.Interfaces;

namespace EjemploTiendaMuebles.TiposDeMuebles
{
    public class SillaModerna : ISilla
    {
        public void Sentarse() => Console.WriteLine("Sentarse en una silla moderna");
    }
}
