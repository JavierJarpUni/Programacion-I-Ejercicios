/* 6.   Leer un número entero de tres dígitos y 
        determinar si algún dígito es múltiplo de los otros.*/
using System.Net;
using System.Security.Cryptography.X509Certificates;

try
{

    Console.WriteLine("Ingrese un numero de tres digitos:");
    string string_num = Console.ReadLine();

    while (Math.Abs(Convert.ToInt32(string_num)) < 100 || Math.Abs(Convert.ToInt32(string_num)) > 999){
        Console.WriteLine("El numero tiene que ser de tres digitos");
        Console.WriteLine("Ingrese un numero otra vez:");
        string_num = Console.ReadLine();
    }

    if (string_num[0].ToString() == "-"){
        string_num = string_num.Substring(1);
    }


    int num1 = Convert.ToInt32(string_num[0].ToString());
    int num2 = Convert.ToInt32(string_num[1].ToString());
    int num3 = Convert.ToInt32(string_num[2].ToString());

    Console.WriteLine("Uno: " + num1.ToString() + "\n" + "Dos: " + num2.ToString() + "\n" + "Tres: " + num3.ToString());


    // Entre num1 y num2
    Console.WriteLine("Posicion una y dos:");
    if (num1 != 0 && num2 != 0) {
        if (num1 % num2 == 0) Console.WriteLine(num2.ToString() + " es multiplo de " + num1.ToString());
        else if (num2 % num1 == 0) Console.WriteLine(num1.ToString() + " es multiplo de " + num2.ToString());
        else Console.WriteLine("No existe combinacion.");
    }

    // Entre num2 y num3
    Console.WriteLine("Posicion dos y tres:");
    if (num2 != 0 && num3 != 0){
        if (num2 % num3 == 0) Console.WriteLine(num3.ToString() + " es multiplo de " + num2.ToString());
        else if (num3 % num2 == 0) Console.WriteLine(num2.ToString() + " es multiplo de " + num3.ToString());
        else Console.WriteLine("No existe combinacion.");
    }

    // Entre num1 y num3
    Console.WriteLine("Posicion una y tres:");
    if (num1 != 0 && num3 != 0){
        if (num1 % num3 == 0) Console.WriteLine(num3.ToString() + " es multiplo de " + num1.ToString());
        else if (num3 % num1 == 0) Console.WriteLine(num1.ToString() + " es multiplo de " + num3.ToString());
        else Console.WriteLine("No existe combinacion.");
    }
    
}
catch (Exception e)
{    
    Console.WriteLine("Eso no es un numero entero.");
}