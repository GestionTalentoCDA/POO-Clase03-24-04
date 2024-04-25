namespace POO_Clase02.Polimorfismo
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public CuentaBancaria( string titular )
        {
            Titular = titular;
            Saldo = 10000;
        }

        public virtual void RealizarDeposito( double monto )
        {
            Saldo += monto;
            Console.WriteLine( $"Depósito de ${monto} realizado. Nuevo saldo: ${Saldo}" );
        }

        public virtual void RealizarRetiro( double monto )
        {
            if (monto <= Saldo)
            {
                Saldo -= monto;
                Console.WriteLine( $"Retiro de ${monto} realizado. Nuevo saldo: ${Saldo}" );
            }
            else
            {
                Console.WriteLine( "Saldo Insuficiente" );
            }
        }

    }
}
