using System;

namespace _06_Decisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  ACTIVIDAD EN CLASE - SEMANA 6");
            Console.WriteLine("  PROYECTO: 06-Decisiones");
            Console.WriteLine("========================================");
            
            // ----------------------------------------------------
            // PARTE 1: Calificación con validación y if-else if-else
            // ----------------------------------------------------
            Console.WriteLine("\n--- PARTE 1: EVALUACIÓN DE CALIFICACIÓN ---");
            Console.Write("Ingrese una nota (0-100): ");
            string inputNota = Console.ReadLine();

            // Validar con int.TryParse y un if
            if (int.TryParse(inputNota, out int nota))
            {
                if (nota >= 0 && nota <= 100)
                {
                    string letra;
                    if (nota >= 90)
                    {
                        letra = "A";
                    }
                    else if (nota >= 80)
                    {
                        letra = "B";
                    }
                    else if (nota >= 70)
                    {
                        letra = "C";
                    }
                    else
                    {
                        letra = "F";
                    }
                    Console.WriteLine($"Calificación: {nota} -> Letra obtenida: {letra}");
                }
                else
                {
                    Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Debe ingresar un número entero.");
            }

            // ----------------------------------------------------
            // PARTE 2: Calculadora con switch y manejo de división entre 0
            // ----------------------------------------------------
            Console.WriteLine("\n--- PARTE 2: CALCULADORA BÁSICA ---");
            Console.Write("Ingrese el primer número: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Ingrese el segundo número: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("\nSeleccione una operación:");
                    Console.WriteLine("1. Sumar (+)");
                    Console.WriteLine("2. Restar (-)");
                    Console.WriteLine("3. Multiplicar (*)");
                    Console.WriteLine("4. Dividir (/)");
                    Console.Write("Elija una opción (1-4): ");
                    
                    if (int.TryParse(Console.ReadLine(), out int opcion))
                    {
                        // Resolver usando switch
                        switch (opcion)
                        {
                            case 1:
                                double suma = num1 + num2;
                                Console.WriteLine($"\nResultado: {num1} + {num2} = {suma:F2}");
                                break;
                            case 2:
                                double resta = num1 - num2;
                                Console.WriteLine($"\nResultado: {num1} - {num2} = {resta:F2}");
                                break;
                            case 3:
                                double producto = num1 * num2;
                                Console.WriteLine($"\nResultado: {num1} * {num2} = {producto:F2}");
                                break;
                            case 4:
                                // Validar división entre cero
                                if (num2 != 0)
                                {
                                    double division = num1 / num2;
                                    Console.WriteLine($"\nResultado: {num1} / {num2} = {division:F2}");
                                }
                                else
                                {
                                    Console.WriteLine("\nError: No es posible dividir entre cero.");
                                }
                                break;
                            default:
                                Console.WriteLine("\nError: Opción no válida. Debe elegir un número del 1 al 4.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Opción de menú inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: El segundo número no es válido.");
                }
            }
            else
            {
                Console.WriteLine("Error: El primer número no es válido.");
            }
        }
    }
}
