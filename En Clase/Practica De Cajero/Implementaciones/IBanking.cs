public interface IBanking{
    void Deposit(Customer CustomerId);
    void Withdraw(Customer customer);
    int Inquiere(Customer customer);
    List<Movimientos> movimientos(Customer customer);
    DetalleTransacciones detalleTransacciones(int TransactionID);
    int Pago(Customer customer);
}