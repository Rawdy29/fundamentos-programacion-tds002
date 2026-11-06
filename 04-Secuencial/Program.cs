using System;

namespace _04_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante de conversión de libras a kilogramos según la consigna (1 lb = 0.453592 kg)
            const double LIBRAS_A_KG = 0.453592;

            double pesoLibras, tempFahrenheit;

            Console.WriteLine("=== CONVERSOR DE UNIDADES (SECUENCIAL) ===");

            // Solicitar el peso en libras
            Console.Write("Ingrese el peso en libras (lb): ");
            pesoLibras = Convert.ToDouble(Console.ReadLine());

            // Solicitar la temperatura en grados Fahrenheit
            Console.Write("Ingrese la temperatura en grados Fahrenheit (°F): ");
            tempFahrenheit = Convert.ToDouble(Console.ReadLine());

            // Procesamiento: Conversiones solicitadas
            double pesoKilogramos = pesoLibras * LIBRAS_A_KG;
            double tempCelsius = (tempFahrenheit - 32) * 5.0 / 9.0;

            // Salida clara utilizando interpolación de cadenas con formato de 2 decimales ({valor:F2})[cite: 6]
            Console.WriteLine("\n--- RESULTADOS DE LA CONVERSIÓN ---");
            Console.WriteLine($"Peso ingresado: {pesoLibras:F2} lb");
            Console.WriteLine($"Equivalente en Kilogramos: {pesoKilogramos:F2} kg");
            Console.WriteLine($"\nTemperatura ingresada: {tempFahrenheit:F2} °F");
            Console.WriteLine($"Equivalente en Grados Celsius: {tempCelsius:F2} °C");
        }
    }
}
