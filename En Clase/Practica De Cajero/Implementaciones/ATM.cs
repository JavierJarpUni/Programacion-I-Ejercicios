
public class ATM : IBanking
{
    public void Deposit(Customer customer)
    {
        customer.saldo += customer.monto;
    }

    public void Deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public DetalleTransacciones detalleTransacciones(int TransactionID)
    {
        throw new NotImplementedException();
    }

    public int Inquiere(Customer customer)
    {
        throw new NotImplementedException();
    }

    public List<Movimientos> movimientos(Customer customer)
    {
        throw new NotImplementedException();
    }

    public int Pago(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void Withdraw(Customer customer)
    {
        customer.saldo -= customer.monto;
    }
}