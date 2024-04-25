namespace POO_Clase02.Encapsulacion.EjemploAeropuerto
{
    internal class CommercialPlane : IFlyingTransport
    {
        public void Fly( string origin, string destination, int passengers )
        {
            Console.WriteLine( "Soy un avion comercial" );
        }
    }
}
