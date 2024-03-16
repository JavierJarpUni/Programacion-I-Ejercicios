public abstract class Herbivoro : Animal
{
    public virtual string tipoDeHierba {get; set;}
    protected Herbivoro(string nombre, string tipoDeHierba) : base(nombre)
    {
        this.nombre = nombre;
        this.tipoDeHierba = tipoDeHierba;
    }
}