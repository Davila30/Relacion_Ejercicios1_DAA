using System;
using System.Collections;

delegate int Operacion(int a, int b);

class EjerciciosDelegados
{
    static int Sumar(int a, int b) => a + b;

    static void Ejercicio1()
    {
        Operacion op = Sumar;
        int resultado = op(10, 5);
        Console.WriteLine($"Ejercicio 1 - Suma (10 + 5): {resultado}");
    }

    static void Main()
    {
        Ejercicio1();
    }
}