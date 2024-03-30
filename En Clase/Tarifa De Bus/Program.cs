// Un peaje que cobra dependiendo del destino al que se dirige

// Rutas se refiere de donde vino, mientras que destino se refiere hacia donde se dirige
List<string> rutas = new List<string>() {
    "Santo Domingo",
    "Samana",
    "Santiago",
    "Punta Cana",
    "La Vega",
    "Puerto Plata",
    "Azua"
};

List<string> destinos = new List<string>(){
    "Samana",
    "Punta Cana",
    "Santiago",
    "Constanza",
    "La Vega"
};
Peaje peaje = new Peaje("Paeje Palito");

bool onOff = true;
string opcion;
Random random = new Random();

while (onOff){
    switch (random.Next(1, 4))
    {
        case (1):
        peaje.CobrarBus(new BusPlatino(rutas[random.Next(0, 7)], (double) random.Next(0, 6), (double) random.Next(4, 7), destinos[random.Next(0, 5)], random.Next(0, 20)));
        break;
        case (2):
        peaje.CobrarBus(new BusGold(rutas[random.Next(0, 7)], (double) random.Next(0, 6), (double) random.Next(4, 7), destinos[random.Next(0, 5)], random.Next(0, 20)));
        break;
        case (3):
        peaje.CobrarBus(new BusBronze(rutas[random.Next(0, 7)], (double) random.Next(0, 6), (double) random.Next(4, 7), destinos[random.Next(0, 5)], random.Next(0, 20)));
        break;
        default:
        Console.WriteLine("No vino un nuevo autobus.");
        break;
    }

    Console.WriteLine("Quieres que el peaje siga abierto?\n\tS: Si\n\tN: No");
    opcion = Console.ReadLine().ToLower();

    switch (opcion)
    {
        case ("s"):
        break;
        case ("n"):
        onOff = false;
        break;
        default:
        Console.WriteLine("No fue una opcion disponible... seguimos");
        break;
    }
}

Console.WriteLine($"Total De Autobuses en esta session: {peaje.count}\nTotal De Pesos Acumulados: ${peaje.acum}");