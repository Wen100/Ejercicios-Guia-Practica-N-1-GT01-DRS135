public class CuentaBancaria
{
    // El saldo se mantiene oculto; solo se accede mediante métodos públicos.
    private decimal saldo;

    public bool Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            return false;
        }

        saldo += monto;
        return true;
    }

    public bool Retirar(decimal monto)
    {
        if (monto <= 0 || monto > saldo)
        {
            return false;
        }

        saldo -= monto;
        return true;
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}
