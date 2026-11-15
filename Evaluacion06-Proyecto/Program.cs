using System;

namespace Evaluacion06_SistemaNotas
{
    class Program
    {
        static string[] nombres = new string[30];
        static string[] matriculas = new string[30];
        static double[] notas1 = new double[30];
        static double[] notas2 = new double[30];
        static double[] notas3 = new double[30];
        static int totalEstudiantes = 0;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                MostrarMenu();
                opcion = LeerEnteroValidado("Seleccione una opción (1-5): ", 1, 5);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        RegistrarEstudiante();
                        break;
                    case 2:
                        MostrarListadoGeneral();
                        break;
                    case 3:
                        BuscarEstudiantePorMatricula();
                        break;
                    case 4:
                        MostrarEstadisticasGenerales();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema... ¡Éxitos en el cuatrimestre!");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione ENTER para volver al menú principal...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (opcion != 5);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("   SISTEMA DE GESTIÓN ACADÉMICA - ITLA (TDS-002)      ");
            Console.WriteLine("======================================================");
            Console.WriteLine("  1. Registrar estudiante y calificaciones");
            Console.WriteLine("  2. Ver listado general y estado de aprobación");
            Console.WriteLine("  3. Buscar estudiante por matrícula");
            Console.WriteLine("  4. Ver estadísticas del curso");
            Console.WriteLine("  5. Salir");
            Console.WriteLine("======================================================");
        }

        static int LeerEnteroValidado(string mensaje, int min, int max)
        {
            int valor;
            bool esValido;

            while (true)
            {
                Console.Write(mensaje);
                esValido = int.TryParse(Console.ReadLine(), out valor);

                if (esValido && valor >= min && valor <= max)
                {
                    return valor;
                }

                Console.WriteLine($"[Error] Ingrese un número entero válido entre {min} y {max}.");
            }
        }

        static double LeerNotaValidada(string mensaje)
        {
            double nota;
            bool esValida;

            while (true)
            {
                Console.Write(mensaje);
                esValida = double.TryParse(Console.ReadLine(), out nota);

                if (esValida && nota >= 0 && nota <= 100)
                {
                    return nota;
                }

                Console.WriteLine("[Error] La calificación debe ser un número entre 0 y 100.");
            }
        }

        static double CalcularPromedio(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }

        static string ObtenerEstadoLiteral(double promedio)
        {
            if (promedio >= 90)
                return "A (Aprobado)";
            else if (promedio >= 80)
                return "B (Aprobado)";
            else if (promedio >= 70)
                return "C (Aprobado)";
            else
                return "F (Reprobado)";
        }

        static void RegistrarEstudiante()
        {
            Console.WriteLine("--- REGISTRAR NUEVO ESTUDIANTE ---\n");

            if (totalEstudiantes >= nombres.Length)
            {
                Console.WriteLine("Capacidad máxima del sistema alcanzada (30 estudiantes).");
                return;
            }

            Console.Write("Nombre completo del estudiante: ");
            string nombre = Console.ReadLine() ?? "";
            while (string.IsNullOrWhiteSpace(nombre))
            {
                Console.Write("[Error] El nombre no puede estar vacío. Ingrese el nombre: ");
                nombre = Console.ReadLine() ?? "";
            }

            Console.Write("Matrícula (ej. 2026-0795): ");
            string matricula = Console.ReadLine() ?? "";
            while (string.IsNullOrWhiteSpace(matricula))
            {
                Console.Write("[Error] La matrícula no puede estar vacía. Ingrese la matrícula: ");
                matricula = Console.ReadLine() ?? "";
            }

            double n1 = LeerNotaValidada("Ingrese Nota 1 (0 - 100): ");
            double n2 = LeerNotaValidada("Ingrese Nota 2 (0 - 100): ");
            double n3 = LeerNotaValidada("Ingrese Nota 3 (0 - 100): ");

            nombres[totalEstudiantes] = nombre.Trim();
            matriculas[totalEstudiantes] = matricula.Trim();
            notas1[totalEstudiantes] = n1;
            notas2[totalEstudiantes] = n2;
            notas3[totalEstudiantes] = n3;
            totalEstudiantes++;

            Console.WriteLine("\n[Éxito] Estudiante registrado correctamente.");
        }

        static void MostrarListadoGeneral()
        {
            Console.WriteLine("--- LISTADO GENERAL DE CALIFICACIONES ---\n");

            if (totalEstudiantes == 0)
            {
                Console.WriteLine("Aún no hay estudiantes registrados en el sistema.");
                return;
            }

            Console.WriteLine($"{"MATRÍCULA",-12} | {"ESTUDIANTE",-24} | {"N1",6} | {"N2",6} | {"N3",6} | {"PROM.",7} | {"ESTADO",-14}");
            Console.WriteLine(new string('-', 88));

            for (int i = 0; i < totalEstudiantes; i++)
            {
                double prom = CalcularPromedio(notas1[i], notas2[i], notas3[i]);
                string estado = ObtenerEstadoLiteral(prom);

                Console.WriteLine($"{matriculas[i],-12} | {nombres[i],-24} | {notas1[i],6:F1} | {notas2[i],6:F1} | {notas3[i],6:F1} | {prom,7:F2} | {estado,-14}");
            }
        }

        static void BuscarEstudiantePorMatricula()
        {
            Console.WriteLine("--- BUSCAR ESTUDIANTE POR MATRÍCULA ---\n");

            if (totalEstudiantes == 0)
            {
                Console.WriteLine("No hay registros disponibles para buscar.");
                return;
            }

            Console.Write("Ingrese la matrícula a buscar: ");
            string busq = (Console.ReadLine() ?? "").Trim();
            bool encontrado = false;

            for (int i = 0; i < totalEstudiantes; i++)
            {
                if (matriculas[i].Equals(busq, StringComparison.OrdinalIgnoreCase))
                {
                    double prom = CalcularPromedio(notas1[i], notas2[i], notas3[i]);
                    string estado = ObtenerEstadoLiteral(prom);

                    Console.WriteLine("\nEstudiante encontrado:");
                    Console.WriteLine($"  Nombre    : {nombres[i]}");
                    Console.WriteLine($"  Matrícula : {matriculas[i]}");
                    Console.WriteLine($"  Notas     : {notas1[i]:F1} / {notas2[i]:F1} / {notas3[i]:F1}");
                    Console.WriteLine($"  Promedio  : {prom:F2}");
                    Console.WriteLine($"  Resultado : {estado}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"\nNo se encontró ningún estudiante con la matrícula '{busq}'.");
            }
        }

        static void MostrarEstadisticasGenerales()
        {
            Console.WriteLine("--- ESTADÍSTICAS DEL CURSO ---\n");

            if (totalEstudiantes == 0)
            {
                Console.WriteLine("No hay datos suficientes para calcular estadísticas.");
                return;
            }

            double sumaPromedios = 0;
            double promMayor = -1;
            double promMenor = 101;
            string mejorEstudiante = "";
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 0; i < totalEstudiantes; i++)
            {
                double prom = CalcularPromedio(notas1[i], notas2[i], notas3[i]);
                sumaPromedios += prom;

                if (prom >= 70)
                    aprobados++;
                else
                    reprobados++;

                if (prom > promMayor)
                {
                    promMayor = prom;
                    mejorEstudiante = nombres[i];
                }

                if (prom < promMenor)
                {
                    promMenor = prom;
                }
            }

            double promedioGeneral = sumaPromedios / totalEstudiantes;

            Console.WriteLine($"Total de estudiantes : {totalEstudiantes}");
            Console.WriteLine($"Promedio del curso   : {promedioGeneral:F2}");
            Console.WriteLine($"Aprobados (>= 70)    : {aprobados}");
            Console.WriteLine($"Reprobados (< 70)    : {reprobados}");
            Console.WriteLine($"Nota más alta        : {promMayor:F2} ({mejorEstudiante})");
            Console.WriteLine($"Nota más baja        : {promMenor:F2}");
        }
    }
}
