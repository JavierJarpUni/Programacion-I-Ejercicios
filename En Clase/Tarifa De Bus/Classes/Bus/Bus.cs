using System.Runtime.InteropServices;

public enum TipoBus
{
    Platino,
    Gold,
    Bronze
}

public abstract class Bus{
    public string ruta {get; set;}
    public double precioTicket {get; set;}
    public double distancia {get; set;}
    public int pasajeros {get; set;}
    public string destino {get; set;}
    public TipoBus tipoBus {get; set;}

    public Bus(string ruta, double precioTicket, double distancia, string destino, int pasajeros){
        this.ruta = ruta;
        this.precioTicket = precioTicket;
        this.distancia = distancia;
        this.pasajeros = pasajeros;
        this.destino = destino;
    }

    public virtual string GetRuta() => this.ruta;
    public virtual double GetTicket() => this.precioTicket;
    public virtual double GetDistancia() => this.distancia;
    public virtual int GetPasajeros() => this.pasajeros;
    public virtual string GetDestino() => this.destino;
    public void RecogerPasajeros(int cantidad){
        Console.WriteLine($"AutoBus Recogio: {cantidad} de pasajeros");
        this.pasajeros += cantidad;
    }

    public override string ToString()
    {
        return $"Bus: {this.tipoBus}\n\tRuta: {this.ruta}\n\tDistancia: {this.distancia}Km\n\tDestino: {this.destino}";
    }
}