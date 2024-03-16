public class LlamadaLocal : Llamada{
    double precio {get; set;}

    public LlamadaLocal (string numOrigen, string numDestino, int duracion) : base(numOrigen, numDestino){
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
        this.duracion = (double) duracion;
    }
    public override double CalcularPrecio()
    {
        this.precio = 0.15 * this.duracion;
        return this.precio;
    }

    public override string ToString()
    {
        return $"Llamada Local\n\tOrigen: {this.numOrigen}\n\tDestino: {this.numDestino}\n\tPrecio: {this.CalcularPrecio()}";
    }
}