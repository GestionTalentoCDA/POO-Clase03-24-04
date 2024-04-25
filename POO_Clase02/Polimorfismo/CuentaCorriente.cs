namespace POO_Clase02.Polimorfismo
{
    public class CuentaCorriente : CuentaBancaria
    {
        public CuentaCorriente( string titular ) : base( titular )
        {
        }

        public override void RealizarDeposito( double monto )
        {
            const double tarifa = 100;
            base.RealizarDeposito( monto - tarifa );
        }
    }
}
