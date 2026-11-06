using System;

namespace Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante del ITBIS (18%)
            const double ITBIS_TASA = 0.18;

            string nombreProducto;
            int cantidad;
            double precioUnitario;

            Console.WriteLine("=== SISTEMA DE FACTURACIÓN ===");
            
            // Entrada de datos
            Console.Write("Ingrese el nombre del producto: ");
            nombreProducto = Console.ReadLine();

            Console.Write("Ingrese la cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: ");
            precioUnitario = Convert.ToDouble(Console.ReadLine());

            // Proceso: Cálculos de factura
            double subtotal = cantidad * precioUnitario;
            double itbis = subtotal * ITBIS_TASA;
            double total = subtotal + itbis;

            // Salida: Factura alineada en columnas usando interpolación y formato
            Console.WriteLine("\n==========================================");
            Console.WriteLine("              FACTURA DE VENTA            ");
            Console.WriteLine("==========================================");
            Console.WriteLine($" Producto: {nombreProducto}");
            Console.WriteLine($" Cantidad: {cantidad}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($" {"Subtotal:",-20} RD$ {subtotal,12:N2}");
            Console.WriteLine($" {"ITBIS (18%):",-20} RD$ {itbis,12:N2}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($" {"TOTAL A PAGAR:",-20} RD$ {total,12:N2}");
            Console.WriteLine("==========================================");
        }
    }
}
