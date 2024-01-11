using EjemploTiendaMuebles.Interfaces;
using EjemploTiendaMuebles.TiposDeMuebles;

namespace EjemploTiendaMuebles.TiposFabricas
{
    public class FabricaMueblesModernos : IMueblesFactory
    {
        public ISilla CrearSilla() => new SillaModerna();
        public ISofa CrearSofa() => new SofaModerno();
        public IMesilla CrearMesilla() => new MesillaModerna();
    }
}
