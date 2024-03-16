public class Movimientos{
    public int IdMovimientos {get; set;}
    public int CustomerID {get; set;}
    public DateTime[] FechasMovimiento {get; set;}
    public string Description {get; set;}
    public string TipoMovimiento {get; set;}
    public decimal Monto {get; set;}
    public string Estado {get; set;}
}