using System;

namespace CajaRegistradora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante del ITBIS (18%)
            const double ITBIS_TASA = 0.18;

            double precio, subtotal = 0;
            int cantidadProductos = 0;

            Console.WriteLine("========================================");
            Console.WriteLine("       CAJA REGISTRADORA - TIENDA       ");
            Console.WriteLine("========================================");
            Console.WriteLine("Ingrese el precio del producto (Escriba 0 para terminar):");

            // Ciclo do-while para leer precios hasta que el usuario escriba 0
            do
            {
                Console.Write("Precio del producto: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out precio))
                {
                    if (precio > 0)
                    {
                        subtotal += precio;
                        cantidadProductos++;
                    }
                    else if (precio < 0)
                    {
                        Console.WriteLine("Error: El precio no puede ser negativo.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Entrada no válida. Ingrese un número.");
                }

            } while (precio != 0);

            // Cálculos finales
            double itbis = subtotal * ITBIS_TASA;
            double total = subtotal + itbis;

            // Salida clara con formato de dos decimales ({valor:N2})
            Console.WriteLine("\n========================================");
            Console.WriteLine("              FACTURA FINAL             ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Cantidad de productos : {cantidadProductos}");
            Console.WriteLine($"Subtotal             : RD$ {subtotal,10:N2}");
            Console.WriteLine($"ITBIS (18%)          : RD$ {itbis,10:N2}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"TOTAL A PAGAR        : RD$ {total,10:N2}");
            Console.WriteLine("========================================");
        }
    }
}
