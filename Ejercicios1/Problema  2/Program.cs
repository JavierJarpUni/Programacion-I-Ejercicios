/* 2.    Leer un número entero de dos dígitos y 
        determinar si es primo y además si es negativo. */

Console.WriteLine("Ingrese un numero de dos digitos: ");

bool es_primo = true;

try {

    string string_num = Console.ReadLine();


    // Confirmar que el numero es de dos digitos
    while (Math.Abs(Convert.ToInt32(string_num)) < 9 || Math.Abs(Convert.ToInt32(string_num)) > 100){
        Console.WriteLine("El numero tiene que ser de dos digitos");
        Console.WriteLine("Ingrese un numero otra vez:");
        string_num = Console.ReadLine();
    }


    // Confirmar si el numero es negativo
    if (string_num[0].ToString() == "-") {
        string_num = string_num.Substring(1);
        Console.WriteLine("El numero es negativo");
    }

    int num = Convert.ToInt32(string_num);

    // Confirmar que el numero es primo
    if (num < 2) es_primo = false;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            es_primo = false;
            break;
        }
    }

    // Resultados
    Console.WriteLine(num + (es_primo ? " es primo." : " no es primo."));

} catch (FormatException){
    Console.WriteLine("No insertaste un numero.");
}