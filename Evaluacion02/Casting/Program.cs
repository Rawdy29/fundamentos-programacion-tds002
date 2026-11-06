using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDecimal;

            Console.WriteLine("--- DEMOSTRACIÓN DE CASTING ---");
            Console.Write("Ingrese un número con decimales (ej. 45.78): ");
            numeroDecimal = Convert.ToDouble(Console.ReadLine());

            // Casting explícito de double a int
            int parteEntera = (int)numeroDecimal;

            // Casting implícito de int a double
            int valorEntero = 100;
            double valorImplicito = valorEntero;

            // Mostrar salidas con interpolación
            Console.WriteLine($"\nNúmero con decimales original: {numeroDecimal}");
            Console.WriteLine($"Casting Explícito a entero (int): {parteEntera}");
            Console.WriteLine($"\nValor entero base: {valorEntero}");
            Console.WriteLine($"Casting Implícito transformado a double: {valorImplicito}");
        }
    }
}
