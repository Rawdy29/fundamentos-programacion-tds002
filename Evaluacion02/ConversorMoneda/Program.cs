using System;

namespace ConversorMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de constante con la tasa del día
            const double TASA_USD = 60.50;

            double montoPesos;

            Console.WriteLine("--- CONVERSOR DE MONEDA ---");
            Console.Write("Ingrese el monto en pesos (DOP): ");
            montoPesos = Convert.ToDouble(Console.ReadLine());

            // Conversión a dólares
            double montoDolares = montoPesos / TASA_USD;

            // Resultado con interpolación
            Console.WriteLine($"\nMonto en Pesos: RD$ {montoPesos:F2}");
            Console.WriteLine($"Tasa de cambio: {TASA_USD} DOP");
            Console.WriteLine($"Equivalente en Dólares: US$ {montoDolares:F2}");
        }
    }
}
