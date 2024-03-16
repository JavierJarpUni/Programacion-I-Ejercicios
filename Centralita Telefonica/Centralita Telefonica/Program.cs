Centralita centralita = new Centralita();

Llamada llamadaProvincial = new LlamadaProvincial("809-203-9239", "809-230-9038", 20, 3);
Llamada llamadaLocal = new LlamadaLocal("809-203-9239", "809-230-9038", 20);

centralita.registerLlamada(llamadaProvincial);
centralita.registerLlamada(llamadaLocal);


bool onOff = true;
Random random = new Random();
string input;
string mensaje = "\nAceptando llamadas...\nAl final de cada ciclo tendras la opcion de apagar la linea.\n1: Apagar\nEnter: Continuar";
Console.WriteLine(mensaje);

while (onOff){
    centralita.registerLlamada(new LlamadaLocal("8" + random.Next(0, 4) + "9-203-023" + random.Next(0, 9) + random.Next(0, 9), "8" + random.Next(0, 4) + "9-203-023" + random.Next(0, 9) + random.Next(0, 9), random.Next(1, 60)));
    centralita.registerLlamada(new LlamadaProvincial("8" + random.Next(0, 4) + "9-203-023" + random.Next(0, 9) + random.Next(0, 9), "8" + random.Next(0, 4) + "9-203-023" + random.Next(0, 9) + random.Next(0, 9), random.Next(1, 60), random.Next(1, 4)));
    input = Console.ReadLine();
    Console.WriteLine(mensaje);

    switch (input)
    {
        case ("1"):
        onOff = false;
        Console.WriteLine("Apagando la linea...");
        break;
        default:
        onOff = true;
        break;
    }
}

Console.WriteLine("\n" + centralita + "\n");

