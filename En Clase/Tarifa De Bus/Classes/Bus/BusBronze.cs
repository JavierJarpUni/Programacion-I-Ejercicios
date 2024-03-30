public class BusBronze : Bus
{
    public BusBronze(string ruta, double precioTicket, double distancia, string destino, int pasajeros) : base(ruta, precioTicket, distancia, destino, pasajeros)
    {
        this.ruta = ruta;
        this.precioTicket = precioTicket;
        this.distancia = distancia;
        this.pasajeros = pasajeros;
        this.destino = destino;
        this.tipoBus = TipoBus.Bronze;
    }
}