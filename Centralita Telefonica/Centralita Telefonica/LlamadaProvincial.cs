public class LlamadaProvincial : Llamada
{

    protected double precio1 {get; set;}
    protected double precio2 {get; set;}
    protected double precio3 {get; set;}
    public int franja {get; set;}
    public LlamadaProvincial(string numOrigen, string numDestino, double duracion) : base(numOrigen, numDestino, duracion)
    {
    }

    public override double calcularPrecio()
    {
        
    }
}