/*  Crear un programa en C# que utilice 
    funciones para determinar si un año es bisiesto. */

void Print(string input) => Console.WriteLine(input);

string Input() => Console.ReadLine();

bool Es_Bisiesto(string ano) {

    Print(String.Format("Determinando si {0} es un año bisiesto...", ano));

    int int_ano = int.Parse(ano);

    if ((int_ano - 2004) % 4 == 0) return true;
    else return false;
}

Print("Inserta un año para determinar si es un año bisiesto: ");

string string_ano = Input();

while (!int.TryParse(string_ano, out int intValue) || string_ano[0].ToString() == "-") {
    Print("Eso no es un año. \n --------- \n Trata otra vez: ");
    string_ano = Input();
}

if (Es_Bisiesto(string_ano)) Print(String.Format("{0} es un año bisiesto.", string_ano));
else Print(String.Format("{0} no es un año bisiesto.", string_ano));