public class Garaje{

    string nombre {get; set;}
    public Coche? coche {get; set;}
    string? averia {get; set;}
    int cochesAtendidos {get; set;}

    private bool disponible {get; set;}

    public Garaje(string nombre){
        this.nombre = nombre;
        disponible = true;
        Console.WriteLine($"Iniciando el garaje {nombre}.\nAceptamos Carros Ya!");
    }

    public void AceptarCoche(Coche nuevoCoche, string averia){

        if (disponible) {
            this.coche = nuevoCoche;
            this.averia = averia;

            if (averia == "aceite") this.coche.GetMotor().IncrementarAceite(10);
            Console.WriteLine($"Aceptamos tu {nuevoCoche}");
            disponible = false;
        }
        else Console.WriteLine("El garaje esta lleno");
    }

    public void DevolverCoche(){

        if (!disponible) {
            Console.WriteLine($"Devolvimos el {coche}."); 
            coche = null;
            disponible = true;
            averia = null;
            UpdateCarFixed();
            // Console.WriteLine($"{nombre} ha arreglado {cochesAtendidos} coches.");
        }
        else {
            Console.WriteLine("El garaje no tiene espacio para mas carros."); 
        }
    }

    private void UpdateCarFixed() => cochesAtendidos++;

    
}