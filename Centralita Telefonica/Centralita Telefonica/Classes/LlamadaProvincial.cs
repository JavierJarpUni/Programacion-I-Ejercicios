using System.ComponentModel;

public class LlamadaProvincial : Llamada
{

    protected double precio1 = 0.20;
    protected double precio2 = 1.25;
    protected double precio3 = 0.30;
    protected double precioFinal {get; set;}
    public int franja {get; set;}
    public LlamadaProvincial(string numOrigen, string numDestino, double duracion, int franja) : base(numOrigen, numDestino, duracion)
    {
        this.numOrigen = numOrigen;
        this.numDestino = numDestino;
        this.duracion = (double) duracion;

        switch (franja)
        {
            case (1):
            this.franja = franja;
            break;
            case (2):
            this.franja = franja;
            break;
            case (3):
            this.franja = franja;
            break;
            default:
            throw new InvalidFranjaException("No existe una franja " + franja.ToString(), franja);
        }
    }

    public override double CalcularPrecio()
    {
        switch (this.franja){
            case (1):
            this.precioFinal = this.precio1 * this.duracion;
            return this.precioFinal;
            case (2):
            this.precioFinal = this.precio2 * this.duracion;
            return this.precioFinal;
            case (3):
            this.precioFinal = this.precio3 * this.duracion;
            return this.precioFinal;
            default:
            return 0.0;
        }
    }

    public override string ToString()
    {
            return $"Llamada Provincial\n\tOrigen: {this.numOrigen}\n\tDestino: {this.numDestino}\n\tPrecio: {this.CalcularPrecio()}";
    }
}