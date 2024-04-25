using POO_Clase02.Polimorfismo;

namespace POO_Clase02
{
    internal class Program
    {
        static void Main( string[] args )
        {
            #region Encapsulacion Ejemplo 1

            //Libro libro = new Libro();

            //libro.Autor = "Gabriel Garcia Marquez";
            //libro.Titulo = "Cien años de soledad";
            //libro.Prestado = false;

            //Console.WriteLine( libro.Autor );

            //libro.Autor = "Herman Hess";
            //libro.Prestado = true;
            //Console.WriteLine( libro.Prestado );

            //Libro l = new Libro( "Herman Hess", "El lobo Estepario" );

            //Console.WriteLine( l.Prestado );

            //Console.WriteLine( l.GetTitulo() + " " + l.GetPrestado() );

            //Console.WriteLine( l.GetTitulo() + " " + l.GetPrestado() );


            #endregion

            #region Encapsulacion Ejemplo 2

            //h.Fly( "Buenos aires", "Montevideo", 4 );

            //privateJet.Fly( "Mendoza", "Santiago de Chile", 15 );

            //Helicopter h = new Helicopter();
            //PrivateJet privateJet = new PrivateJet();
            //Airport a = new Airport();

            //a.Accept( h );
            //a.Accept( privateJet );

            //CommercialPlane c = new CommercialPlane();
            //a.Accept( c );

            //PrivateJet privateJet = new PrivateJet();
            //Airport a = new Airport();
            //a.Accept( privateJet );

            #endregion

            #region Sobreescritura

            //CuentaBancaria cb = new CuentaBancaria( "Fernando Mossier" );
            //Console.WriteLine( cb.Saldo );
            //cb.RealizarDeposito( 5000 );
            //cb.RealizarRetiro( 2000 );

            //CuentaCorriente cc = new CuentaCorriente( "Ale" );
            //Console.WriteLine( cc.Saldo );
            //cc.RealizarRetiro( 2000 );
            //cc.RealizarDeposito( 5000 );

            CuentaAhorro ca = new CuentaAhorro( "Fer" );
            Console.WriteLine( ca.Saldo );
            ca.RealizarDeposito( 5000 );
            ca.RealizarRetiro( 2000 );




            #endregion







            Console.ReadKey();
        }
    }
}