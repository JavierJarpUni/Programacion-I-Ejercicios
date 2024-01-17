/* 5.    Leer un número entero de tres dígitos y 
       determinar en qué posición está el mayor dígito. */

using System.Xml.Linq;

try {
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


    int past_num = 0;
    int current_num = 0;
    foreach (char i in string_num)
    {
        if (i == string_num[0]) {past_num = Convert.ToInt32(i.ToString()); continue;}

        current_num = Convert.ToInt32(i.ToString());

        Console.WriteLine("Current: " + current_num.ToString() + "\n" + "Past: " + past_num.ToString());
        if (current_num > past_num) {
            Console.WriteLine(current_num.ToString() + " es mas grande que " + past_num.ToString());
            past_num = current_num;
            }
    }

    
    Console.WriteLine("El numero mas grande de " + string_num + " es " + (past_num > current_num ? past_num.ToString() : current_num.ToString()));
} catch (Exception e) {
    Console.WriteLine("Eso no es un numero entero.");
}