using System;

namespace Reto_TiposDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RETO: Tipos de Datos y Conversión ===");

            Console.Write("Ingrese su año de nacimiento (ej. 2002): ");
            string entradaAnio = Console.ReadLine();

            if (int.TryParse(entradaAnio, out int anioNacimiento))
            {
                int anioActual = DateTime.Now.Year;
                int edadCalculada = anioActual - anioNacimiento;

                Console.WriteLine($"¡Conversión exitosa!");
                Console.WriteLine($"Usted tiene o cumplirá {edadCalculada} años en el año {anioActual}.");
            }
            else
            {
                Console.WriteLine("Error: El valor ingresado no es un número entero válido.");
            }
        }
    }
}