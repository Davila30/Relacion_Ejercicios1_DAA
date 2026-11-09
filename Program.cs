using System;
using System.Collections;

class Bloque1Secuenciales
{
    // 1. Operaciones básicas: suma, resta, multiplicación, división y módulo
    public static void Ejercicio1()
    {
        Console.Write("Introduce el primer número: ");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Introduce el segundo número: ");
        int n2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"La suma es {n1 + n2}");
        Console.WriteLine($"La resta es: {n1 - n2}");
        Console.WriteLine($"La multiplicación es: {n1 * n2}");
        Console.WriteLine($"La división es: {n1 / n2}");
        Console.WriteLine($"El módulo es: {n1 % n2}");
    }

    // 2. Cuenta de bar con constantes
    public static void Ejercicio2()
    {
        const double PRECIO_HAMBURGUESA = 4.50;
        const double PRECIO_PAPAS = 2.75;
        const double PRECIO_BEBIDA = 1.20;

        Console.Write("Cantidad de hamburguesas: ");
        int hamburguesas = int.Parse(Console.ReadLine()!);
        Console.Write("Cantidad de papas: ");
        int papas = int.Parse(Console.ReadLine()!);
        Console.Write("Cantidad de bebidas: ");
        int bebidas = int.Parse(Console.ReadLine()!);

        double total = (hamburguesas * PRECIO_HAMBURGUESA) +
                       (papas * PRECIO_PAPAS) +
                       (bebidas * PRECIO_BEBIDA);

        Console.WriteLine($"Cantidad a pagar: {total:F2}€");
    }

    // 3. Operaciones matemáticas con Math
    public static void Ejercicio3()
    {
        Console.Write("Introduce un número: ");
        double num = double.Parse(Console.ReadLine()!);
        double auxiliar = 10; // Número constante para operaciones que requieren dos argumentos

        Console.WriteLine($"Valor absoluto: {Math.Abs(num)}");
        Console.WriteLine($"Potencia al cubo: {Math.Pow(num, 3)}");
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(Math.Abs(num))}");
        Console.WriteLine($"Seno: {Math.Sin(num)}");
        Console.WriteLine($"Coseno: {Math.Cos(num)}");
        Console.WriteLine($"Máximo entre {num} y {auxiliar}: {Math.Max(num, auxiliar)}");
        Console.WriteLine($"Mínimo entre {num} y {auxiliar}: {Math.Min(num, auxiliar)}");
    }

    // 4. Perímetro de un cuadrado
    public static void Ejercicio4()
    {
        Console.Write("Introduce el valor del lado: ");
        double lado = double.Parse(Console.ReadLine()!);
        double perimetro = 4 * lado;
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
    }

    // 5. Suma de los dos primeros y producto del tercero y cuarto
    public static void Ejercicio5()
    {
        Console.Write("Número 1: ");
        double n1 = double.Parse(Console.ReadLine()!);
        Console.Write("Número 2: ");
        double n2 = double.Parse(Console.ReadLine()!);
        Console.Write("Número 3: ");
        double n3 = double.Parse(Console.ReadLine()!);
        Console.Write("Número 4: ");
        double n4 = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Suma de los dos primeros: {n1 + n2}");
        Console.WriteLine($"Producto del tercero y cuarto: {n3 * n4}");
    }

    // 6. Suma y promedio de cuatro valores
    public static void Ejercicio6()
    {
        Console.Write("Valor 1: ");
        double n1 = double.Parse(Console.ReadLine()!);
        Console.Write("Valor 2: ");
        double n2 = double.Parse(Console.ReadLine()!);
        Console.Write("Valor 3: ");
        double n3 = double.Parse(Console.ReadLine()!);
        Console.Write("Valor 4: ");
        double n4 = double.Parse(Console.ReadLine()!);

        double suma = n1 + n2 + n3 + n4;
        double promedio = suma / 4;

        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio}");
    }

    // 7. Coste total según precio unitario y cantidad
    public static void Ejercicio7()
    {
        Console.Write("Introduce el precio del artículo: ");
        double precio = double.Parse(Console.ReadLine()!);
        Console.Write("Introduce la cantidad adquirida: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        double total = precio * cantidad;
        Console.WriteLine($"El coste total a pagar es: {total:F2}€");
    }

    // 8. Nota final ponderada
    public static void Ejercicio8()
    {
        Console.Write("Nota parcial 1: ");
        double p1 = double.Parse(Console.ReadLine()!);
        Console.Write("Nota parcial 2: ");
        double p2 = double.Parse(Console.ReadLine()!);
        Console.Write("Nota del examen: ");
        double examen = double.Parse(Console.ReadLine()!);
        Console.Write("Nota del trabajo final: ");
        double trabajo = double.Parse(Console.ReadLine()!);

        double promParciales = (p1 + p2) / 2.0;
        double notaFinal = (promParciales * 0.50) + (examen * 0.30) + (trabajo * 0.20);

        Console.WriteLine($"Tu nota final en Desarrollo de Interfaces es: {notaFinal:F2}");
    }

    // 9. Porcentaje de participación de tres socios (formato compuesto)
    public static void Ejercicio9()
    {
        Console.Write("Aportación del socio 1: ");
        double s1 = double.Parse(Console.ReadLine()!);
        Console.Write("Aportación del socio 2: ");
        double s2 = double.Parse(Console.ReadLine()!);
        Console.Write("Aportación del socio 3: ");
        double s3 = double.Parse(Console.ReadLine()!);

        double total = s1 + s2 + s3;
        double pct1 = (s1 / total) * 100;
        double pct2 = (s2 / total) * 100;
        double pct3 = (s3 / total) * 100;

        Console.WriteLine("El porcentaje del socio 1 es {0:F1}%, del socio 2 es {1:F1}% y del socio 3 es {2:F1}%", pct1, pct2, pct3);
    }

    // 10. Comprobar si un string comienza por "www"
    public static void Ejercicio10()
    {
        Console.Write("Introduce una cadena de texto o URL: ");
        string texto = Console.ReadLine()!;
        bool comienza = texto.StartsWith("www", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine($"Comienza por 'www': {comienza}");
    }
}