/* 
Dispositivos:
    modelo
    bateria

    Getters
    Prender
    Apagar

*/

public abstract class Dispositivo{
    public virtual string nombre {get; set;}
    public virtual string modelo {get; set;}
    public virtual float bateria {get; set;}
    public virtual bool prendido {get; set;}

    public Dispositivo(string nombre, string modelo, int bateria){
        this.nombre = nombre;
        this.modelo = modelo;
        this.bateria = (float) bateria;
    }

    public virtual float GetCharge() => bateria;
    public virtual string GetModel() => modelo;

    public virtual void Prender() {
        Console.WriteLine($"Prendiendo {this.nombre}.");
        this.prendido = true;
    }

    public virtual void Apagar(){
        this.prendido = false;
        Console.WriteLine($"Apagando {this.nombre}");
    }
}

public class Telefono : Dispositivo
{

    public string numeroDeTelefono {get; set;}
    public Telefono(string nombre, string modelo, int bateria, string numeroDeTelefono) : base(nombre, modelo, bateria)
    {
        this.numeroDeTelefono = numeroDeTelefono;
    }

    public void Llamar(string numero){
        if (this.prendido){
            Console.WriteLine($"{this.nombre} esta llamando {numero}.");
        }
        else Console.WriteLine($"{this.nombre} esta apagando. Prendelo para poder llamar.");
    }
}