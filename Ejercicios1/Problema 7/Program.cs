/* 7.   Leer tres números enteros y 
        determinar cuál es el mayor. Usar solamente dos variables. */

        Console.WriteLine("Ingresa un numero entero: ");

        string string_num1 = Console.ReadLine();

        while (!int.TryParse(string_num1, out int intValue)){
            Console.WriteLine("Eso no es un numero entero.");
            Console.WriteLine("Trata de nuevo:");
            string_num1 = Console.ReadLine();
        }
        Console.WriteLine("Ingresa otro numero entero: ");

        string string_num2 = Console.ReadLine();

        while (!int.TryParse(string_num2, out int intValue)){
            Console.WriteLine("Eso no es un numero entero.");
            Console.WriteLine("Trata de nuevo:");
            string_num2 = Console.ReadLine();
        }

        // Comparacion de los primeros dos numeros

        if (Convert.ToInt32(string_num1) > Convert.ToInt32(string_num2)) Console.WriteLine(string_num1 + " es mas grande que " + string_num2 + ".");
        else {Console.WriteLine(string_num2 + " es mas grande que " + string_num1 + "."); string_num1 = string_num2;}
        
        Console.WriteLine("Ingresa otro numero entero: ");

        string_num1 = Console.ReadLine();

        while (!int.TryParse(string_num1, out int intValue)){
            Console.WriteLine("Eso no es un numero entero.");
            Console.WriteLine("Trata de nuevo:");
            string_num1 = Console.ReadLine();
        }

        if (Convert.ToInt32(string_num1) > Convert.ToInt32(string_num2)) Console.WriteLine(string_num1 + " es el mas grande de todos.");
        else Console.WriteLine(string_num2 + " es el mas grande de todos.");