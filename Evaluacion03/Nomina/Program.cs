using System;

namespace Nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constantes de porcentaje para deducciones de ley
            const double PORCENTAJE_AFP = 0.0287; // 2.87%
            const double PORCENTAJE_SFS = 0.0304; // 3.04%

            string nombreEmpleado;
            double horasTrabajadas, pagoPorHora;

            Console.WriteLine("=== CÁLCULO DE NÓMINA EMPLEADO ===");
            
            // Entrada de datos
            Console.Write("Ingrese el nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();

            Console.Write("Ingrese las horas trabajadas: ");
            horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el pago por hora: ");
            pagoPorHora = Convert.ToDouble(Console.ReadLine());

            // Proceso: Cálculos salariales
            double salarioBruto = horasTrabajadas * pagoPorHora;
            double montoAfp = salarioBruto * PORCENTAJE_AFP;
            double montoSfs = salarioBruto * PORCENTAJE_SFS;
            double salarioNeto = salarioBruto - (montoAfp + montoSfs);

            // Salida: Nombre en MAYÚSCULAS y montos con formato {valor:N2}
            Console.WriteLine("\n==================================");
            Console.WriteLine($"EMPLEADO: {nombreEmpleado.ToUpper()}");
            Console.WriteLine("==================================");
            Console.WriteLine($"Salario Bruto : RD$ {salarioBruto:N2}");
            Console.WriteLine($"Deducción AFP : RD$ {montoAfp:N2}");
            Console.WriteLine($"Deducción SFS : RD$ {montoSfs:N2}");
            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"Salario Neto  : RD$ {salarioNeto:N2}");
            Console.WriteLine("==================================");
        }
    }
}
