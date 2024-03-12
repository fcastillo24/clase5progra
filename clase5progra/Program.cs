
while (true)
{
    Console.WriteLine("Por Favor Seleccione qu Ejercicio Desea Realizar:\n");
    Console.WriteLine("1. Numero Menor y Mayor");
    Console.WriteLine("2. Aidivnar Numero");
    Console.WriteLine("3. Contador de Palabras");
    Console.WriteLine("4. Polimodros");
    Console.WriteLine("5. Salir\n");

    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    switch (opcion)
    {
        case 1: 
            Ejercicio1();
            break;
        case 2: 
            Ejercicio2();
            break;
        case 3: 
            Ejercicio3();
            break;
        case 4: 
            Ejercicio4();
            break;
        case 5:
            return;
        default: 
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
            break;
    }
}
static void Ejercicio1()
{
    {
        double mayor = double.MinValue; 
        double menor = double.MaxValue; 

        
        while (true)
        {
            Console.Write("Ingrese un valor positivo (o 0 para terminar): ");
            double num = Convert.ToDouble(Console.ReadLine());

            
            if (num == 0)
                break;

            
            if (num > 0)
            {
                
                if (num > mayor)
                    mayor = num;
                if (num < menor)
                    menor = num;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un valor positivo.");
            }
        }

        
        if (mayor != double.MinValue && menor != double.MaxValue)
        {
            Console.WriteLine("El número mayor ingresado es: " + mayor);
            Console.WriteLine("El número menor ingresado es: " + menor);
        }
        else
        {
            Console.WriteLine("No se ingresaron valores positivos.");
        }
    }
}

static void Ejercicio2()
{
    static int adivinar()
    {
        int num = 0, resultados = 0;
        Console.WriteLine("anote un numero. Multiplicado por 2, sumele 8, y multi´pliquelo por 5, e ingrese el resultdo");
        num = Convert.ToInt32(Console.ReadLine());
        resultados = (num / 10) - 4;
        Console.WriteLine($"el numero que pensastes es:{resultados}");
        return resultados;
    }
    adivinar();
}

static void Ejercicio3()
{
        Console.WriteLine("Ingrese una frase:");
        string frase = (Console.ReadLine());

        int cantidadPalabras = 0;
        int cantidadVocales = 0;
        int index = 0;
        string vocales = "aeiouAEIOU";

        
        while (index < frase.Length)
        {
           
            while (index < frase.Length && frase[index] == ' ')
                index++;

            
            if (index < frase.Length && frase[index] != ' ')
                cantidadPalabras++;

            
            while (index < frase.Length && frase[index] != ' ')
                index++;
        }

        
        foreach (char caracter in frase)
        {
            if (vocales.Contains(caracter))
                cantidadVocales++;
        }

        Console.WriteLine("Número de palabras en la frase: " + cantidadPalabras);
        Console.WriteLine("Número de vocales en la frase: " + cantidadVocales);
    
}

static void Ejercicio4()
{
    Console.WriteLine("Ingrese una palabra:");
    string pala = (Console.ReadLine());

    bool esPalindromo = true;

    // Verificamos si la palabra es un palíndromo utilizando un bucle for
    for (int i = 0; i < pala.Length / 2; i++)
    {
        if (pala[i] != pala[pala.Length - 1 - i])
        {
            esPalindromo = false;
            break;
        }
    }

    // Mostramos el resultado en la consola
    if (esPalindromo)
        Console.WriteLine("La palabra ingresada es un palíndromo.");
    else
        Console.WriteLine("La palabra ingresada no es un palíndromo.");
}
