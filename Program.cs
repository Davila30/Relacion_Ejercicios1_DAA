using System;
using System.Collections;

delegate int Operacion(int a, int b);

class EjerciciosDelegados
{
    static int Sumar(int a, int b) => a + b;
    static int Restar(int a, int b) => a - b;

    static void Main(string[] args)
    {
        Operacion op = Sumar;
        Console.WriteLine($"Suma: {op(10, 5)}");

        Operacion op2 = Restar;
        Console.WriteLine($"Resta: {op2(10, 5)}");
    }
}