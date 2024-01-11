using EjemploTiendaMuebles.Interfaces;
using EjemploTiendaMuebles.TiposFabricas;

namespace EjemploTiendaMuebles
{
    public class ConfiguradorTiendaMuebles
    {
        public void Inicializar()
        {
            // Aquí puedes leer la configuración de la aplicación (por ejemplo, desde un archivo de configuración)
            string tipoMuebles = LeerTipoMueblesDesdeConfig();

            IMueblesFactory fabrica;
            if (tipoMuebles == "Modernos")
            {
                fabrica = new FabricaMueblesModernos();
            }
            else if (tipoMuebles == "Victorianos")
            {
                fabrica = new FabricaMueblesVictorianos();
            }
            else if (tipoMuebles == "Art Deco")
            {
                fabrica = new FabricaMueblesArtDeco();
            }
            else
            {
                throw new Exception("Error! Tipo de muebles desconocido.");
            }

            SimuladorTiendaMuebles simulador = new SimuladorTiendaMuebles(fabrica);

            // Llamada para iniciar la creación de muebles en el simulador
            simulador.CrearMuebles();
        }

        public string LeerTipoMueblesDesdeConfig()
        {
            // Lógica para leer la configuración del tipo de muebles
            return "Modernos"; // Ejemplo, podrías leerlo desde un archivo de configuración.
        }
    }

}
