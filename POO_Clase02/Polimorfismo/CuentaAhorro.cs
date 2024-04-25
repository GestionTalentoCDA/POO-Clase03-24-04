namespace POO_Clase02.Polimorfismo
{
    public class CuentaAhorro : CuentaBancaria
    {
        public CuentaAhorro( string titular ) : base( titular )
        {
        }

        public override void RealizarRetiro( double monto )
        {
            const double penalizacion = 200;
            base.Saldo -= penalizacion;
            base.RealizarRetiro( monto );
        }
    }
}
