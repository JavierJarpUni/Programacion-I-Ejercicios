using System.Diagnostics.Contracts;

public class Motor{
    private int litros_de_aceite {get; set;}
    private int potencia {get; set;}

    public Motor(int potencia){
        this.potencia = potencia;
        this.litros_de_aceite = 0;
    }

    public int GetAceite(){
        return litros_de_aceite;
    }

    public int GetPotencia(){
        return potencia;
    }

    public void SetAceite(int valor){
        this.litros_de_aceite = valor;
    }

    public void IncrementarAceite(int valor){
        this.litros_de_aceite += valor;
    }

    public void SetPotencia(int valor){
        this.potencia = valor;
    }
}