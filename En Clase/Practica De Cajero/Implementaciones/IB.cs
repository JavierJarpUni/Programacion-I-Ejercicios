
using System.Reflection.Metadata.Ecma335;

public class IB : IBanking
{
    
    public void Deposit(Customer customer)
    {
        customer.saldo += customer.monto;
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