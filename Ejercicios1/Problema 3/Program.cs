/* 3.    Leer un número entero de dos dígitos y
        determinar si sus dos dígitos son primos. */
// try {   
// Console.WriteLine("Ingrese un numero entero de dos digitos: ");

// string string_num = Console.ReadLine();

// bool es_primo = true;
// bool es_negativo;

// if (Convert.ToInt32(string_num) < 0){
//     string_num = string_num.Substring(1);
//     es_negativo = true;
// } else es_negativo = false;

// string string_num1 = string_num[0].ToString();
// string string_num2 = string_num[1].ToString();

// int num1 = Convert.ToInt32(string_num1);
// int num2 = Convert.ToInt32(string_num2);

// if (!es_negativo){
//     for (int i = 2; i < num1; i++)
//     {
//         if (i == 1) {Console.WriteLine(num1.ToString() + " no es un numero primo"); continue;}
//             if (num1 % i != 0){
//                 Console.WriteLine("El numero " + num1.ToString() + " es divisible por el valor " + i.ToString() + ".");
//                 Console.WriteLine(num1.ToString() + " no es un numero primo");
//                 es_primo = false;
//                 break;
//             }
//         if (!es_primo) Console.WriteLine(num1.ToString() + " no es un numero primo");
//     }
// } else {
//         int abs_num = Math.Abs(num1);
//         for (int i = 2; i < abs_num; i++)
//         {
//             if (i == 1) {Console.WriteLine(num1.ToString() + " no es un numero primo"); continue;}
//             if (abs_num % i == 0){
//                 Console.WriteLine("El numero " + num1.ToString() + " es divisible por el valor " + i.ToString() + ".");
//                 Console.WriteLine(num1.ToString() + " no es un numero primo.");
//                 es_primo = false;
//                 break;
//             }
//         }
// }

// es_negativo = false;

// if (num2 != 0){
// if (!es_negativo){
//     for (int i = 2; i < num2; i++)
//     {
//         if (i == 1) {Console.WriteLine(num2.ToString() + " no es un numero primo"); continue;}
//             if (num2 % i != 0){
//                 Console.WriteLine("El numero " + num2.ToString() + " es divisible por el valor " + i.ToString() + ".");
//                 Console.WriteLine(num2.ToString() + " no es un numero primo");
//                 es_primo = false;
//                 break;
//             }
//         if (!es_primo) Console.WriteLine(num2.ToString() + " no es un numero primo");
//     }
// } else {
//         int abs_num = Math.Abs(num2);
//         for (int i = 2; i < abs_num; i++)
//         {
//             if (i == 1) {Console.WriteLine(num2.ToString() + " no es un numero primo"); continue;}
//             if (abs_num % i == 0){
//                 Console.WriteLine("El numero " + num2.ToString() + " es divisible por el valor " + i.ToString() + ".");
//                 Console.WriteLine(num2.ToString() + " no es un numero primo.");
//                 es_primo = false;
//                 break;
//             }
//         }
// }
// } else {
//     Console.WriteLine("0 no es un numero primo");
// }
// }
// catch (Exception e) {
//     Console.WriteLine("Eso no es un numero");
// }

Console.WriteLine("Ingrese un numero entero de dos digitos: ");

try {

    string string_num = Console.ReadLine();

    bool es_primo1 = true;
    bool es_primo2 = true;

    while (Math.Abs(Convert.ToInt32(string_num)) < 9 || Math.Abs(Convert.ToInt32(string_num)) > 100){
        Console.WriteLine("El numero tiene que ser de dos digitos");
        Console.WriteLine("Ingrese un numero otra vez:");
        string_num = Console.ReadLine();
    }

    if (string_num[0].ToString() == "-") {
        string_num = string_num.Substring(1);
    }

    string string_num1 = string_num[0].ToString();
    string string_num2 = string_num[1].ToString();

    int num1 = Convert.ToInt32(string_num1);
    int num2 = Convert.ToInt32(string_num2);

    // Verifica si el primer dígito es primo
    if (num1 < 2) es_primo1 = false;
    for (int i = 2; i < num1; i++)
    {
        if (num1 % i == 0)
        {
            es_primo1 = false;
            break;
        }
    }

    // Verifica si el segundo dígito es primo
    if (num2 < 2) es_primo2 = false;
    for (int i = 2; i < num2; i++)
    {
        if (num2 % i == 0)
        {
            es_primo2 = false;
            break;
        }
    }

    // Resultados
    Console.WriteLine(num1 + (es_primo1 ? " es primo." : " no es primo."));
    Console.WriteLine(num2 + (es_primo2 ? " es primo." : " no es primo."));
} catch (Exception e){
    Console.WriteLine("Eso no es un numero");
}