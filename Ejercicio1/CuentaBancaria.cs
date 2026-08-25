namespace Ejercicio1
{
    /// <summary>
    /// Representa una cuenta bancaria. El saldo permanece encapsulado
    /// y solo se modifica mediante operaciones publicas validadas.
    /// </summary>
    public class CuentaBancaria
    {
        private decimal saldo;

        /// <summary>
        /// Agrega dinero a la cuenta si el monto es positivo.
        /// </summary>
        public bool Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                return false;
            }

            saldo += monto;
            return true;
        }

        /// <summary>
        /// Retira dinero de la cuenta si el monto es valido y hay fondos suficientes.
        /// </summary>
        public bool Retirar(decimal monto)
        {
            if (monto <= 0 || monto > saldo)
            {
                return false;
            }

            saldo -= monto;
            return true;
        }

        /// <summary>
        /// Devuelve el saldo actual de la cuenta.
        /// </summary>
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }
}
