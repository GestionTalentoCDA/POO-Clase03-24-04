namespace POO_Clase02.Encapsulacion.EjemploAeropuerto
{
    public class PrivateJet : IFlyingTransport
    {
        public void Fly( string origin, string destination, int passengers )
        {
            Console.WriteLine( "Soy un Jet Privado y estoy volando" );
        }
    }
}
