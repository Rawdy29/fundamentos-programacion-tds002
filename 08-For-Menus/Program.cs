using System;

namespace _08_For_Menus
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            // Menú principal utilizando do-while y switch
            do
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("    MENÚ PRINCIPAL - ACTIVIDAD SEMANA 8 ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Mostrar tablas de multiplicar (1 al 10)");
                Console.WriteLine("2. Dibujar triángulo de asteriscos");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // 1. Ciclos anidados para mostrar las tablas del 1 al 10 en columnas alineadas ({valor,4})
                            Console.WriteLine("\n--- TABLAS DE MULTIPLICAR (1 al 10) ---");
                            for (int i = 1; i <= 10; i++)
                            {
                                for (int j = 1; j <= 10; j++)
                                {
                                    Console.Write($"{i * j,4}");
                                }
                                Console.WriteLine(); // Salto de línea por cada fila de la tabla
                            }
                            break;

                        case 2:
                            // 2. Triángulo de asteriscos de N filas escrito por el usuario
                            Console.WriteLine("\n--- TRIÁNGULO DE ASTERISCOS ---");
                            Console.Write("Ingrese el número de filas (N): ");
                            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                            {
                                for (int i = 1; i <= n; i++)
                                {
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write("*");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: Por favor ingrese un número entero positivo válido.");
                            }
                            break;

                        case 0:
                            Console.WriteLine("\nSaliendo del programa... ¡Hasta luego!");
                            break;

                        default:
                            Console.WriteLine("\nError: Opción no válida. Elija 1, 2 o 0.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nError: Entrada no válida. Ingrese un número entero.");
                    opcion = -1; // Mantener el ciclo activo
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
