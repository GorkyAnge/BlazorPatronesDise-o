using EjemploTiendaMuebles.Interfaces;
using EjemploTiendaMuebles.TiposDeMuebles;

namespace EjemploTiendaMuebles.TiposFabricas
{
    public class FabricaMueblesArtDeco : IMueblesFactory
    {
        public ISilla CrearSilla() => new SillaArtDeco();
        public ISofa CrearSofa() => new SofaArtDeco();
        public IMesilla CrearMesilla() => new MesillaArtDeco();
    }
}
