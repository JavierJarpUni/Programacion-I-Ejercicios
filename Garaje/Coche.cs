public class Coche {
    private Motor motor {get; set;}
    string marca {get; set;}
    string modelo {get; set;}

    double averias {get; set;}
    public Coche(string marca, string modelo){
        this.marca = marca;
        this.modelo = modelo;
        this.motor = new Motor(new Random().Next(0, 5));
        Console.WriteLine($"Tienes un {marca}");
    }

    public string GetMarca() => this.marca;
    public Motor GetMotor() => this.motor;
    public string GetModelo() => this.modelo;
    public double GetAverias() => this.averias;

    public void acumularAveria(double valor){
        this.averias += valor;
        Console.WriteLine($"El carro acumulo {valor} en averias.");
    }
}