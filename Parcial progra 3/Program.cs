using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Tabla de Multiplicar ---");

        int numeroTabla;

        Console.Write("Ingrese un número para imprimir la tabla de multiplicar: ");
        while (!int.TryParse(Console.ReadLine(), out numeroTabla))
        {
            Console.Write("Ingrese un número entero válido: ");
        }

        ImprimirTablaMultiplicar(numeroTabla);

        Console.WriteLine("\nFin del programa.");
    }

    static void ImprimirTablaMultiplicar(int numero)
    {
        Console.WriteLine($"Tabla de multiplicar del {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
