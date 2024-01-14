/* 1.    Leer un número entero de dos dígitos y determinar a cuánto es 
        igual la suma de sus dígitos. */

Console.WriteLine("Ingresa un numero de dos digitos: ");
string num = Console.ReadLine();
try {
    if (Math.Abs(Convert.ToInt32(num)) > 100 || Math.Abs(Convert.ToInt32(num)) < 10){
        Console.WriteLine("Eso no es un numero de dos digitos");
    }

    if (Convert.ToInt32(num) < 0){
            num = num.Substring(1);
            Console.WriteLine(num);
        }

    var string_num1 = num[0];
    var string_num2 = num[1];

    Console.WriteLine("As chars: " + string_num1 + " " + string_num2);
    
    int num1 = Convert.ToInt32(string_num1.ToString());
    int num2 = Convert.ToInt32(string_num2.ToString());


    int resultado = num1 + num2;
    Console.WriteLine("El Resultado es: " + resultado.ToString());
}
catch (Exception e){
    Console.WriteLine("Eso no es un numero.");
}
