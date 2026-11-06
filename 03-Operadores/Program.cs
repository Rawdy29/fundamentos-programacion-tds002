using System;

namespace _03_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables para los dos números enteros
            int num1, num2;

            Console.WriteLine("=== OPERACIONES ARITMÉTICAS Y LÓGICAS ===");
            
            // Lectura de los números enteros
            Console.Write("Ingrese el primer número entero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Operaciones
            int suma = num1 + num2;
            int resta = num1 - num2;
            int producto = num1 * num2;
            
            // División real (convirtiendo uno a double para no perder decimales)
            double divisionReal = (num2 != 0) ? (double)num1 / num2 : 0;
            
            // División entera y residuo
            int divisionEntera = (num2 != 0) ? num1 / num2 : 0;
            int residuo = (num2 != 0) ? num1 % num2 : 0;

            // Verificar si el primer número es par (true/false)
            bool esPar = (num1 % 2 == 0);

            // Mostrar resultados usando interpolación de cadenas
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Suma ({num1} + {num2}): {suma}");
            Console.WriteLine($"Resta ({num1} - {num2}): {resta}");
            Console.WriteLine($"Producto ({num1} * {num2}): {producto}");
            
            if (num2 != 0)
            {
                Console.WriteLine($"División real ({num1} / {num2}): {divisionReal:F2}");
                Console.WriteLine($"División entera ({num1} / {num2}): {divisionEntera}");
                Console.WriteLine($"Residuo / Módulo ({num1} % {num2}): {residuo}");
            }
            else
            {
                Console.WriteLine("División y residuo: No es posible dividir entre cero.");
            }

            Console.WriteLine($"¿El primer número ({num1}) es par?: {esPar}");
        }
    }
}

/*
 =====================================================================
 PRUEBA DE ESCRITORIO : x = 10, y = 3)
 =====================================================================
 Variables de entrada:
   x = 10
   y = 3

 Procesamiento y evaluación paso a paso:
   1. Suma:         10 + 3  = 13
   2. Resta:        10 - 3  = 7
   3. Producto:     10 * 3  = 30
   4. División real:  (double)10 / 3 = 3.333...
   5. División entera: 10 / 3 = 3
   6. Residuo (módulo): 10 % 3 = 1  (porque 3 * 3 = 9, para llegar a 10 falta 1)
   7. ¿Es par? (x % 2 == 0): 10 % 2 == 0 -> true (10 es par)

 Salida esperada en pantalla para x = 10 e y = 3:
   - Suma: 13
   - Resta: 7
   - Producto: 30
   - División real: 3.33
   - División entera: 3
   - Residuo: 1
   - ¿El primer número es par?: True
 =====================================================================
*/
