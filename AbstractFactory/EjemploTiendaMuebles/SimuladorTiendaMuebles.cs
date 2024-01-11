using EjemploTiendaMuebles.Interfaces;

namespace EjemploTiendaMuebles
{
    public class SimuladorTiendaMuebles
    {
        private readonly IMueblesFactory fabrica;

        public SimuladorTiendaMuebles(IMueblesFactory fabrica)
        {
            this.fabrica = fabrica;
        }

        public void CrearMuebles()
        {
            var silla = fabrica.CrearSilla();
            var sofa = fabrica.CrearSofa();
            var mesilla = fabrica.CrearMesilla();

            // Realizar operaciones con los productos (por ejemplo, combinarlos)
            Console.WriteLine("Creando muebles con la siguiente configuración:");

            // Utilizar métodos de los productos concretos
            silla.Sentarse();
            sofa.Recostarse();
            mesilla.ColocarObjetos();

            Console.WriteLine("Operaciones de creación de muebles completadas.");
        }
    }
}
