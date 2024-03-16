public abstract class Animal{
    public string nombre {get; set;}

    public Animal(string nombre){
        this.nombre = nombre;
    }

    public abstract void Movimiento();
}