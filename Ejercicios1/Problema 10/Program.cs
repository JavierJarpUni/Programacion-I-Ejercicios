/*  10. Leer dos números enteros y 
    si la diferencia entre los dos es menor o igual a 10 
    entonces mostrar en pantalla todos los enteros comprendidos entre el menor y 
    el mayor de los números leídos. */

Console.WriteLine("Ingrese un numero entero:");
string string_num1 = Console.ReadLine();

while (!int.TryParse(string_num1, out int intValue)){
    Console.WriteLine("Trata de nuevo:");
    string_num1 = Console.ReadLine();
}

// if (string_num1.Substring(1) == "-") {
//     string_num1 = string_num1.Substring(1);
// }

Console.WriteLine("Ingresa otro numero entero:");
string string_num2 = Console.ReadLine();

while (!int.TryParse(string_num2, out int intValue)){
    Console.WriteLine("Trata de nuevo:");
    string_num2 = Console.ReadLine();
}

if (Convert.ToInt32(string_num1) - Convert.ToInt32(string_num2) <= 10){
    Console.WriteLine("La diferencia entre " + string_num1 + " y " + string_num2 + " es menor o igual que 10.");



    Console.WriteLine(string.Format("Todos los digitos dentro del numero {0}.", string_num1));
    if (string_num1[0].ToString() == "-") {
        string_num1 = string_num1.Substring(1);
    }
    foreach (char i in string_num1)
    {
        Console.WriteLine(i);
    }
    
    Console.WriteLine(string.Format("Todos los digitos dentro del numero {0}.", string_num1));
    if (string_num1[0].ToString() == "-") {
        string_num1 = string_num1.Substring(1);
    }
    foreach (char i in string_num1)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine(string.Format("Todos los digitos dentro del numero {0}.", string_num2));
    if (string_num2[0].ToString() == "-") {
        string_num2 = string_num2.Substring(1);
    }
    foreach (char i in string_num2)
    {
        Console.WriteLine(i);
    }
}