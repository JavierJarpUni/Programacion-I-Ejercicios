/* 8.    Leer un número entero de cinco dígitos 
        y determinar si es un número Capicúa. 
        Ej. 15651, 59895.  */


using System.Timers;

Console.WriteLine("Ingresa un numero entero de cinco digitos:");

string string_num = Console.ReadLine();

while (!int.TryParse(string_num, out int intValue) || Math.Abs(Convert.ToInt32(string_num)) < 10000 || Math.Abs(Convert.ToInt32(string_num)) > 99999){
    Console.WriteLine("Eso no es un numero entero de cinco digitos.");
    Console.WriteLine("Trata de nuevo:");
    string_num = Console.ReadLine();
}

if (string_num.Substring(1) == "-") {
    string_num = string_num.Substring(1);
}

char[] charArray = string_num.ToCharArray();
Array.Reverse(charArray);
string inverse_string_num = new string(charArray);

if (string_num == inverse_string_num){
    Console.WriteLine("El numero " + string_num + " es capicua.");
} else {
    Console.WriteLine("El numero " + string_num + " no es capicua.");
}