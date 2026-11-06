using System;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            double radioCirculo, catetoA, catetoB;

            Console.WriteLine("=== CÁLCULOS GEOMÉTRICOS ===");

            // Entrada de datos
            Console.Write("Ingrese el radio del círculo: ");
            radioCirculo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el primer cateto del triángulo rectángulo: ");
            catetoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo cateto del triángulo rectángulo: ");
            catetoB = Convert.ToDouble(Console.ReadLine());

            // Proceso: Uso de Math.PI, Math.Pow y Math.Sqrt
            double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
            double circunferencia = 2 * Math.PI * radioCirculo;
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

            // Salida clara con 2 decimales
            Console.WriteLine("\n--- RESULTADOS GEOMÉTRICOS ---");
            Console.WriteLine($"Círculo (Radio: {radioCirculo:F2}):");
            Console.WriteLine($"  - Área          : {areaCirculo:F2}");
            Console.WriteLine($"  - Circunferencia: {circunferencia:F2}");
            
            Console.WriteLine($"\nTriángulo Rectángulo (Catetos: {catetoA:F2} y {catetoB:F2}):");
            Console.WriteLine($"  - Hipotenusa    : {hipotenusa:F2}");
        }
    }
}
