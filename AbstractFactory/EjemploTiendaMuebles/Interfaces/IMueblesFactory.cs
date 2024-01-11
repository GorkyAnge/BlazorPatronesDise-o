namespace EjemploTiendaMuebles.Interfaces
{
    public interface IMueblesFactory
    {
        ISilla CrearSilla();
        ISofa CrearSofa();
        IMesilla CrearMesilla();
    }
}
