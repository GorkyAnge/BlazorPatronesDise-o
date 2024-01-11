using EjemploTiendaMuebles.Interfaces;

namespace EjemploTiendaMuebles.TiposDeMuebles
{
    public class MesillaModerna : IMesilla
    {
        public void ColocarObjetos() => Console.WriteLine("Colocar objetos en una mesilla moderna");
    }
}
