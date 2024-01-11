using EjemploTiendaMuebles.Interfaces;
using EjemploTiendaMuebles.TiposDeMuebles;

namespace EjemploTiendaMuebles.TiposFabricas
{
    public class FabricaMueblesVictorianos : IMueblesFactory
    {
        public ISilla CrearSilla() => new SillaVictoriana();
        public ISofa CrearSofa() => new SofaVictoriano();
        public IMesilla CrearMesilla() => new MesillaVictoriana();
    }
}
