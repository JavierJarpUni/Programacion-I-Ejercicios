public class PracticaPOO {
    
    public PracticaPOO(){
        Garaje garaje = new Garaje("D'Wilkin Garaje");

        Coche toyota = new Coche("Toyota", "Camry");
        Coche suzuki = new Coche("Suzuki", "Swift");
        

        garaje.AceptarCoche(toyota, "aceite");

        double randomNumber;
        Random RNG = new Random();
        randomNumber = RNG.NextDouble() * (10.0 - 1.0) + 1.0;
        garaje.coche.acumularAveria(randomNumber);

        garaje.DevolverCoche();

        garaje.AceptarCoche(suzuki, "aceite");
        randomNumber = RNG.NextDouble() * (10.0 - 1.0) + 1.0;
        garaje.coche.acumularAveria(randomNumber);

        garaje.DevolverCoche();

        garaje.AceptarCoche(toyota, "aceite");

        randomNumber = RNG.NextDouble() * (10.0 - 1.0) + 1.0;
        garaje.coche.acumularAveria(randomNumber);

        garaje.DevolverCoche();

        garaje.AceptarCoche(toyota, "aceite");
        randomNumber = RNG.NextDouble() * (10.0 - 1.0) + 1.0;
        garaje.coche.acumularAveria(randomNumber);

        garaje.DevolverCoche();

        garaje.AceptarCoche(suzuki, "aceite");
        randomNumber = RNG.NextDouble() * (10.0 - 1.0) + 1.0;
        garaje.coche.acumularAveria(randomNumber);

        garaje.DevolverCoche();

        Console.WriteLine($"Informacion Del Toyota:\n Motor:\n  Aceite: {toyota.GetMotor().GetAceite()}\n  Potencia: {toyota.GetMotor().GetAceite()}\n Marca: {toyota.GetMarca()}\n Modelo: {toyota.GetModelo()}");
        Console.WriteLine($"Informacion Del Suzuki:\n Motor:\n  Aceite: {suzuki.GetMotor().GetAceite()}\n  Potencia: {suzuki.GetMotor().GetPotencia()}\n Marca: {suzuki.GetMarca()}\n Modelo: {suzuki.GetModelo()}");
    }
}