public abstract class Llamada{
    public string numOrigen {get; protected set;}
    public string numDestino {get; protected set;}
    public double duracion {get; protected set;}

    public Llamada(string numOrigen, string numDestino, double duracion){
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
        this.duracion = duracion;
    }

    protected Llamada(string numOrigen, string numDestino)
    {
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
    }

    public string getNumOrigen() => this.numOrigen;
    public string getNumDestino() => this.numDestino;
    public double getDuracion() => this.duracion;
    public abstract double CalcularPrecio();
}