using System;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ANIO_ACTUAL = 2026;

            string nombre;
            int edad;
            double estatura;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
            estatura = Convert.ToDouble(Console.ReadLine());

            int anioNacimiento = ANIO_ACTUAL - edad;

            Console.WriteLine("\n--- Información Personal ---");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura} m");
            Console.WriteLine($"Año de nacimiento aproximado: {anioNacimiento}");
        }
    }
}
