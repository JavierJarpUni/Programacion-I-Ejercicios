/* 4.   Leer dos números enteros de dos dígitos y 
        determinar si la suma de los dos números origina un número par. */
try {
    Console.WriteLine("Ingrese un numero de dos digitos");

    string string_num1 = Console.ReadLine();


    while (Math.Abs(Convert.ToInt32(string_num1)) < 9 || Math.Abs(Convert.ToInt32(string_num1)) > 100){
        Console.WriteLine("El numero tiene que ser de dos digitos");
        Console.WriteLine("Ingrese un numero otra vez:");
        string_num1 = Console.ReadLine();
    }

    if (string_num1[0].ToString() == "-") {
        string_num1 = string_num1.Substring(1);
    }

    int num1_of_num1 = Convert.ToInt32(string_num1[0].ToString());

    int num2_of_num1 = Convert.ToInt32(string_num1[1].ToString());
    Console.WriteLine("Gracias!");

    Console.WriteLine("Ingrese otro numero de dos digitos");

    string string_num2 = Console.ReadLine();


    while (Math.Abs(Convert.ToInt32(string_num2)) < 9 || Math.Abs(Convert.ToInt32(string_num2)) > 100){
        Console.WriteLine("El numero tiene que ser de dos digitos");
        Console.WriteLine("Ingrese un numero otra vez:");
        string_num2 = Console.ReadLine();
    }

    if (string_num2[0].ToString() == "-") {
        string_num2 = string_num2.Substring(1);
    }

    int num1_of_num2 = Convert.ToInt32(string_num2[0].ToString());
    int num2_of_num2 = Convert.ToInt32(string_num2[1].ToString());

    int suma = num1_of_num1 + num1_of_num2 + num2_of_num1 + num2_of_num2;

    Console.WriteLine("La suma de todos los digitos de ambos numeros es: " + suma.ToString());

    if (suma % 2 == 0) Console.WriteLine("La suma de todos los digitos de ambos numeros " + suma.ToString() + " es par.");
    else Console.WriteLine("La suma de todos los digitos de ambos numeros, " + suma.ToString() + " no es par.");
} catch (Exception e) {
    Console.WriteLine("Eso no es un numero entero.");
}