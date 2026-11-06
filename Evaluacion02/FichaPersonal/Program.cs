using System;

namespace FichaPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante para calcular el año en que cumplirá 30
            const int ANIO_ACTUAL = 2026;

            // Variables solicitadas con sus tipos correctos
            string nombre;
            int edad;
            double estatura;
            bool trabaja;

            // Lectura de datos
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
            estatura = Convert.ToDouble(Console.ReadLine());

            Console.Write("¿Trabaja actualmente? (true/false): ");
            trabaja = Convert.ToBoolean(Console.ReadLine());

            // Cálculo del año en que cumplirá 30 años
            int anioNacimiento = ANIO_ACTUAL - edad;
            int anioCumple30 = anioNacimiento + 30;

            // Salida clara con interpolación de cadenas
            Console.WriteLine("\n--- FICHA PERSONAL ---");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura} m");
            Console.WriteLine($"¿Trabaja?: {(trabaja ? "Sí" : "No")}");
            Console.WriteLine($"Año en que cumplirá 30 años: {anioCumple30}");
        }
    }
}
