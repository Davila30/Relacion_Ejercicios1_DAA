using System;
using System.Collections;

delegate int Operacion(int a, int b);

class EjerciciosDelegados
{
    static int Resta(int a, int b) => a - b;

    static void Ejercicio1()
    {
        Operacion op = Resta;
        int resultado = op(10, 5);
        Console.WriteLine($"La resta de 10 y 5 es = {resultado}");
    }

    static void Main()
    {
        Ejercicio1();
    }
}