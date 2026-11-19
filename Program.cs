using System;
using System.Collections;

delegate int Operacion(int a, int b);
delegate int Operar(int a, int b);
delegate int OperarArray(int[] numeros);
delegate int Transformar(int n);
delegate int OperacionCallback(int a, int b);
delegate double Calculo(double n);

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

    // Métodos del Ejercicio 8
    static int Doblar(int n) => n * 2;
    static int Triplicar(int n) => n * 3;
    static int Cuadrado(int n) => n * n;

    // Método del Ejercicio 9
    static int EjecutarOperacion(OperacionCallback callback, int a, int b)
    {
        return callback(a, b);
    }

    // Métodos del Ejercicio 10
    static double RaizCuadrada(double n)
    {
        if (n < 0)
            throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
        return Math.Sqrt(n);
    }

    static double Logaritmo(double n)
    {
        if (n <= 0)
            throw new ArgumentException("El logaritmo solo está definido para números mayores que cero.");
        return Math.Log(n);
    }

    static void CalcularSeguro(Calculo calc, double numero)
    {
        try
        {
            double resultado = calc(numero);
            Console.WriteLine($"{calc.Method.Name}({numero}) = {resultado:F4}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en {calc.Method.Name}({numero}): {ex.Message}");
        }
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

        // Ejercicio 8: Delegados y Retornos Condicionales
        Console.WriteLine("\n=== EJERCICIO 8 ===");
        int numero = 5;
        Transformar trans = Doblar;
        trans += Triplicar;
        trans += Cuadrado;

        foreach (Transformar metodo in trans.GetInvocationList())
        {
            Console.WriteLine($"{metodo.Method.Name}({numero}) = {metodo(numero)}");
        }

        // Ejercicio 9: Delegados y Funciones de Callback
        Console.WriteLine("\n=== EJERCICIO 9 ===");
        Console.WriteLine($"Callback Suma (7, 2): {EjecutarOperacion(Suma, 7, 2)}");
        Console.WriteLine($"Callback Resta (7, 2): {EjecutarOperacion(Resta, 7, 2)}");
        Console.WriteLine($"Callback Multiplicar (7, 2): {EjecutarOperacion(Multiplicar, 7, 2)}");

        // Ejercicio 10: Delegados y Manejo de Errores
        Console.WriteLine("\n=== EJERCICIO 10 ===");
        CalcularSeguro(RaizCuadrada, 25);
        CalcularSeguro(RaizCuadrada, -9);
        CalcularSeguro(Logaritmo, 10);
        CalcularSeguro(Logaritmo, 0);
    }
}