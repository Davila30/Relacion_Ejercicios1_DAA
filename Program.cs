using System;
using System.Collections;

delegate int Operacion(int a, int b);
delegate int Operar(int a, int b);
delegate int OperarArray(int[] numeros);

class EjerciciosDelegados
{
    static int Sumar(int a, int b) => a + b;
    static int Restar(int a, int b) => a - b;
    static int Multiplicar(int a, int b) => a * b;
    static int Dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return 0;
        }
        return a / b;
    }

    // Método del Ejercicio 5
    static void EjecutarYMostrar(Operacion op, int x, int y)
    {
        int resultado = op(x, y);
        Console.WriteLine($"Operación {op.Method.Name}({x}, {y}) = {resultado}");
    }

    // Métodos del Ejercicio 6
    static int Suma(int a, int b) => a + b;
    static int Resta(int a, int b) => a - b;
    static int Multiplicacion(int a, int b) => a * b;

    // Métodos del Ejercicio 7
    static int SumaArray(int[] numeros)
    {
        int total = 0;
        foreach (int n in numeros) total += n;
        return total;
    }

    static int MultiplicarArray(int[] numeros)
    {
        if (numeros.Length == 0) return 0;
        int total = 1;
        foreach (int n in numeros) total *= n;
        return total;
    }

    static void Main(string[] args)
    {
        // Ejercicio 4: Delegados con Diferentes Métodos
        Console.WriteLine("=== EJERCICIO 4 ===");
        Operacion op = Sumar;
        op += Restar;
        op += Multiplicar;
        op += Dividir;

        foreach (Operacion metodo in op.GetInvocationList())
        {
            Console.WriteLine($"Resultado ({metodo.Method.Name}): {metodo(10, 0)}");
        }

        // Ejercicio 5: Delegados y Retornos
        Console.WriteLine("\n=== EJERCICIO 5 ===");
        EjecutarYMostrar(Sumar, 8, 4);
        EjecutarYMostrar(Restar, 8, 4);
        EjecutarYMostrar(Multiplicar, 8, 4);

        // Ejercicio 6: Delegados y Nombres
        Console.WriteLine("\n=== EJERCICIO 6 ===");
        Operar operar = Suma;
        operar += Resta;
        operar += Multiplicacion;

        foreach (Operar metodo in operar.GetInvocationList())
        {
            Console.WriteLine($"Método: {metodo.Method.Name} -> Resultado: {metodo(6, 3)}");
        }

        // Ejercicio 7: Delegados y Arrays
        Console.WriteLine("\n=== EJERCICIO 7 ===");
        int[] datos = { 2, 3, 4 };
        OperarArray opArray = SumaArray;
        opArray += MultiplicarArray;

        foreach (OperarArray metodo in opArray.GetInvocationList())
        {
            Console.WriteLine($"Método: {metodo.Method.Name} -> Resultado: {metodo(datos)}");
        }
    }
}