namespace POO_Clase02.Encapsulacion.EjemploAeropuerto
{
    public class Airport
    {
        public void Accept( IFlyingTransport flyingTransport )
        {
            flyingTransport.Fly( "origen", "destino", 12 );
            Console.WriteLine( $"Soy el aeropuerto y un {flyingTransport.GetType().Name} aterrizó en mi pista" );
        }
    }
}
