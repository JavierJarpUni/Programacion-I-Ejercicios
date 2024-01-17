/* 9.   Leer un número entero de cuatro dígitos y 
        determinar si el segundo dígito es igual al penúltimo. */

Console.WriteLine("Ingrese un numero de cuatro digitos:");
string string_num = Console.ReadLine();

while (!int.TryParse(string_num, out int intValue) || Math.Abs(Convert.ToInt32(string_num)) <= 999 || Math.Abs(Convert.ToInt32(string_num)) > 9999){
    Console.WriteLine("Eso no es un numero entero de cinco digitos.");
    Console.WriteLine("Trata de nuevo:");
    string_num = Console.ReadLine();
}

if (string_num.Substring(1) == "-"){
    string_num = string_num.Substring(1);
}

char segundo_digito = string_num[1];
char penultimo_digito = string_num[2];

if (segundo_digito == penultimo_digito)
    Console.WriteLine("El segundo digito " + segundo_digito + " es igual al penultimo digito " + penultimo_digito + ".");
else 
    Console.WriteLine("El segundo digito " + segundo_digito + " no es igual al penultimo digito " + penultimo_digito + ".");