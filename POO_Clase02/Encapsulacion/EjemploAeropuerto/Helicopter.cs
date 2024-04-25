namespace POO_Clase02.Encapsulacion.EjemploAeropuerto
{
    public class Helicopter : IFlyingTransport
    {
        public void Fly( string origin, string destination, int passengers )
        {
            Console.WriteLine( "Soy un helicoptero y estoy volando" );
        }
    }
}
