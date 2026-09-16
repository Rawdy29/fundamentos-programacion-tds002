/*
 * Nombre: Rawdy Alcantara Carrasco
 * Fecha: 16/09/2026
 * Descripción: Programa que imprime una tarjeta de presentación
 * con nombre, matrícula, carrera y una frase personal, usando
 * un marco hecho de caracteres.
 */

using System;

class Program
{
    static void Main()
    {
        // Datos personales que se mostrarán en la tarjeta
        string nombre = "Rawdy Alcantara Carrasco";
        string matricula = "2026-0795";
        string carrera = "Ingeniería en Ciberseguridad";
        string frase = "Apasionado por la tecnología y la ciberseguridad";

        // Se construye el marco superior e inferior de la tarjeta
        string marco = new string('=', 50);

        // Impresión de la tarjeta de presentación
        Console.WriteLine(marco);
        Console.WriteLine("|" + Centrar("TARJETA DE PRESENTACIÓN", 48) + "|");
        Console.WriteLine(marco);
        Console.WriteLine("| Nombre    : " + nombre.PadRight(34) + "|");
        Console.WriteLine("| Matrícula : " + matricula.PadRight(34) + "|");
        Console.WriteLine("| Carrera   : " + carrera.PadRight(34) + "|");

        // Marco de la frase, calculado según su longitud para que siempre encaje
        int anchoFrase = frase.Length + 4;
        Console.WriteLine(new string('*', anchoFrase));
        Console.WriteLine("| " + frase + " |");
        Console.WriteLine(new string('*', anchoFrase));
    }

    // Método auxiliar para centrar texto dentro de un ancho dado
    static string Centrar(string texto, int ancho)
    {
        int espacios = ancho - texto.Length;
        int izquierda = espacios / 2;
        int derecha = espacios - izquierda;
        return new string(' ', izquierda) + texto + new string(' ', derecha);
    }
}