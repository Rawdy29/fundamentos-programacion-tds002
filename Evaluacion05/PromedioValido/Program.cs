using System;

namespace PromedioValido
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            int sumaNotas = 0;
            int cantidadNotas = 0;
            int notaMayor = -1;
            int notaMenor = 101;

            Console.WriteLine("========================================");
            Console.WriteLine("       CÁLCULO DE PROMEDIO VÁLIDO       ");
            Console.WriteLine("========================================");
            Console.WriteLine("Ingrese notas válidas (0-100). Escriba -1 para terminar:");

            do
            {
                Console.Write("Ingrese nota (-1 para salir): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out nota))
                {
                    // Condición para salir del ciclo
                    if (nota == -1)
                    {
                        break;
                    }

                    // Validar rango de 0 a 100
                    if (nota >= 0 && nota <= 100)
                    {
                        sumaNotas += nota;
                        cantidadNotas++;

                        // Evaluar nota mayor y menor
                        if (nota > notaMayor)
                        {
                            notaMayor = nota;
                        }
                        if (nota < notaMenor)
                        {
                            notaMenor = nota;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0 y 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada no válida. Ingrese un número entero.");
                }

            } while (true);

            // Mostrar resultados si se ingresaron notas
            Console.WriteLine("\n========================================");
            Console.WriteLine("            RESULTADOS FINALES          ");
            Console.WriteLine("========================================");

            if (cantidadNotas > 0)
            {
                double promedio = (double)sumaNotas / cantidadNotas;
                Console.WriteLine($"Total de notas ingresadas : {cantidadNotas}");
                Console.WriteLine($"Promedio general          : {promedio:F2}");
                Console.WriteLine($"Nota más alta             : {notaMayor}");
                Console.WriteLine($"Nota más baja             : {notaMenor}");
            }
            else
            {
                Console.WriteLine("No se ingresaron notas válidas para calcular.");
            }
            Console.WriteLine("========================================");
        }
    }
}
