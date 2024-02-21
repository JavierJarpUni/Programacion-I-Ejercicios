public class Efectivo : Ipagos{
    public int Valor {get; set;}

    public Efectivo(int valor){
        valor = valor;
    }

    void Ipagos.Pagar()
    {
        Console.WriteLine("Pago con Efectivo.");
    }
}