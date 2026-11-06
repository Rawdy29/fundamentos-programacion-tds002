using System;

namespace _07_Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool esValido = false;

            Console.WriteLine("==================================================");
            Console.WriteLine("  ACTIVIDAD EN CLASE - SEMANA 7: CICLOS");
            Console.WriteLine("==================================================");

            // 1. Pide un número entre 1 y 12 y valídalo con do-while (repite hasta que sea válido)
            do
            {
                Console.Write("Ingrese un número entero entre 1 y 12: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero) && numero >= 1 && numero <= 12)
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Error: El número debe estar entre 1 y 12. Intente nuevamente.");
                }
            } while (!esValido);

            Console.WriteLine($"\nNúmero aceptado: {numero}");
            Console.WriteLine($"--- TABLA DE MULTIPLICAR DEL {numero} ---");

            // 2. Muestra su tabla de multiplicar del 1 al 12 con while (usa un contador)
            int contador = 1;
            
            // 3. Acumulador para sumar todos los resultados de la tabla
            int acumuladorSuma = 0;

            while (contador <= 12)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {resultado}");

                // Sumamos al acumulador
                acumuladorSuma += resultado;

                // Incrementamos el contador
                contador++;
            }

            // Mostrar la suma de todos los resultados
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Suma total de todos los resultados: {acumuladorSuma}");
            Console.WriteLine("==================================================");
        }
    }
}
