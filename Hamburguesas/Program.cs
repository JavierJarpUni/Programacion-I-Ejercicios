// Hamburguesa hamburguesa = new Hamburguesa("Integral", "Res");
// Console.WriteLine(hamburguesa);
// Console.WriteLine(hamburguesa.GetPrecio());

// hamburguesa.AgregarIngredientes(["Pepinillo", "Tomate", "Bacon", "Queso"]);
// Console.WriteLine(hamburguesa);
// Console.WriteLine(hamburguesa.GetPrecio());

// Console.WriteLine("Hamburgesa Saludable:\n");

// HamburguesaSaludable hamburguesaSaludable = new HamburguesaSaludable("Res", "Ketchup", "Lechuga");
// hamburguesaSaludable.AgregarIngredientes(["Pepinillo", "Tomate", "Bacon", "Queso"]);
// hamburguesaSaludable.GetPrecio();
// Console.WriteLine(hamburguesaSaludable);

// Console.WriteLine("Hamburguesa Premium:\n");

// HamburguesaPremium hamburguesaPremium = new HamburguesaPremium("Res", "Agua");
// hamburguesaPremium.AgregarIngredientes(["Pepinillo", "Tomate", "Bacon", "Queso"]);
// Console.WriteLine(hamburguesaPremium);
// Console.WriteLine(hamburguesaPremium.GetPrecio());


using System.Runtime.InteropServices;

Dictionary<string, int> ingredientes_adicionales = new Dictionary<string, int>(){
    {"Pepinillo", 1},
    {"Lechuga", 2},
    {"Tomates", 3},
    {"Bacon", 4},
    {"Ketchup", 5},
    {"Queso", 6},
    {"Papas Fritas", 7},
    {"Refresco", 8}
};

// string[] EligeIngredientesAdicionales(string tipo){

//     List<string> ingredientesSeleccionados = new List<string>();
//     bool continuar = true;
//     int count = 0;
//     while (continuar)
//     {
//         Console.WriteLine("Elige uno de los ingredientes (escribe el nombre exacto o 'Listo' para finalizar): ");
//         foreach (var item in ingredientes_adicionales)
//         {
//             Console.WriteLine($"{item.Key}");
//         }
        
//         string seleccion = Console.ReadLine().Trim();
//         if (seleccion.Equals("Listo", StringComparison.OrdinalIgnoreCase) || (tipo == "HamburguesaSaludable" && count >= 4) || (tipo == "HamburguesaPremium"))
//         {
//             continuar = false;
//         }
//         else if (ingredientes_adicionales.ContainsKey(seleccion))
//         {
//             ingredientesSeleccionados.Add(seleccion);
//             count++;
//         }
//         else
//         {
//             Console.WriteLine("Ingrediente no reconocido. Por favor, intenta de nuevo.");
//         }
//     }
//     return ingredientesSeleccionados.ToArray();
// }

string[] EligeIngredientesAdicionales(string tipo)
{
    if (tipo == "HamburguesaPremium") // Si es premium, no permitir ingredientes adicionales
    {
        return new string[] {}; // Retorna un arreglo vacío inmediatamente
    }

    List<string> ingredientesSeleccionados = new List<string>();
    bool continuar = true;
    int count = 0;
    while (continuar && (tipo != "HamburguesaSaludable" || count < 4)) // Límite de 4 ingredientes para Saludable
    {
        Console.WriteLine("Elige uno de los ingredientes (escribe el nombre exacto o 'Listo' para finalizar): ");
        foreach (var item in ingredientes_adicionales)
        {
            Console.WriteLine($"{item.Key}");
        }
        
        string seleccion = Console.ReadLine().Trim();
        if (seleccion.Equals("Listo", StringComparison.OrdinalIgnoreCase) || count >= 4)
        {
            continuar = false;
        }
        else if (ingredientes_adicionales.ContainsKey(seleccion))
        {
            ingredientesSeleccionados.Add(seleccion);
            count++;
        }
        else
        {
            Console.WriteLine("Ingrediente no reconocido. Por favor, intenta de nuevo.");
        }
    }
    return ingredientesSeleccionados.ToArray();
}

// Hamburguesa? EligeHamburguesa(){
//     Hamburguesa hamburguesa;
//     string carne;
//     string pan = "";
//     Console.WriteLine("Elige tu hamburguesa:");
//     string opcion = "";
//     Console.WriteLine("\nHamburguesa Clasica:\t1\nHamburguesa Premium:\t2\nHamburguesa Saludable:\t3\n");

//     switch (opcion)
//     {
//         case ("1"):
//         Console.WriteLine("Escribe el tipo de carne:");
//         carne = Console.ReadLine();
//         Console.WriteLine("Escribe el tipo de pan:");
//         pan = Console.ReadLine();
//         hamburguesa = new Hamburguesa(pan, carne);
//         return hamburguesa;

//         case("2"):
//         Console.WriteLine("Escribe el tipo de carne:");
//         carne = Console.ReadLine();
//         Console.WriteLine("Escribe el tipo de pan:");
//         pan = Console.ReadLine();
//         hamburguesa = new HamburguesaPremium(pan, carne);
//         return hamburguesa;

//         case ("3"):
//         Console.WriteLine("Escribe el tipo de carne:");
//         carne = Console.ReadLine();
//         string[] _ingredientes = new string[2];
//         for (int i = 0; i < 3; i++)
//         {
//             foreach (var item in ingredientes_adicionales)
//             {
//                 Console.WriteLine($"{item.Key}");
//             }

//             Console.WriteLine("Elige uno de los ingredientes adicionales:");
//             string _opcion = Console.ReadLine();

//             _ingredientes.Append(_opcion);
//         }
//         hamburguesa = new HamburguesaSaludable(carne, _ingredientes[0], _ingredientes[1]);
//         return hamburguesa;

//         default:
//         return hamburguesa = new Hamburguesa("Agua", "Res");
//         break;
//     }
// }

Hamburguesa? EligeHamburguesa()
{
    // Asumiendo que tienes una clase base Hamburguesa y subclases para cada tipo
    // La implementación específica dependerá de cómo hayas definido estas clases
    Console.WriteLine("Elige tu hamburguesa:\n1. Hamburguesa Clasica\n2. Hamburguesa Premium\n3. Hamburguesa Saludable");
    string opcion = Console.ReadLine();
    string carne, pan;

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Escribe el tipo de carne:");
            carne = Console.ReadLine();
            Console.WriteLine("Escribe el tipo de pan:");
            pan = Console.ReadLine();
            return new Hamburguesa(pan, carne);

        case "2":
            Console.WriteLine("Escribe el tipo de carne:");
            carne = Console.ReadLine();
            Console.WriteLine("Escribe el tipo de pan:");
            pan = Console.ReadLine();
            return new HamburguesaPremium(pan, carne); // Asumimos constructor adecuado

        case "3":
            Console.WriteLine("Escribe el tipo de carne:");
            carne = Console.ReadLine();
            // Asumimos que HamburguesaSaludable toma ingredientes de manera diferente
            string[] ingredientes = new string[2];
            foreach (KeyValuePair<string, int> item in ingredientes_adicionales)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Escoge dos ingredientes:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            return new HamburguesaSaludable(carne, input1, input2);

        default:
            return null;
    }
}

bool onOff = true;
Random random = new Random();
string input;
string mensaje = "\nMenu online:\n1: Apagar\nEnter: Continuar";
Console.WriteLine("\nInicializando el programa... " + mensaje);
List<Hamburguesa> lista = new List<Hamburguesa>();

while (onOff)
{
    Hamburguesa? hamburguesa = EligeHamburguesa();
    if (hamburguesa != null)
    {
        string tipo = hamburguesa.GetType().Name;
        if (tipo != "HamburguesaPremium") // Si no es premium, pregunta por ingredientes adicionales
        {
            string[] ingredientes = EligeIngredientesAdicionales(tipo);
            hamburguesa.AgregarIngredientes(ingredientes);
        }

        Console.WriteLine("Tu Hamburguesa:");
        Console.WriteLine(hamburguesa.ToString());
    }
    lista.Add(hamburguesa);

    Console.WriteLine("\n¿Deseas pedir otra hamburguesa? (Sí = 1 / No = Cualquier otra tecla)");
    string continuar = Console.ReadLine();
    onOff = continuar == "1";
}

double total = 0.0;
foreach (Hamburguesa item in lista)
{
    total += item.GetPrecio();
}

Console.WriteLine($"La cuenta es: {total}");