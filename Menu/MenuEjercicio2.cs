using System;
using Ejercicio2;

namespace Menu
{
    /// <summary>
    /// Ejecuta el ejercicio 2: empleado con encapsulacion y validacion.
    /// </summary>
    public class MenuEjercicio2
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2: Encapsulacion y control de acceso - Empleado\n");

            Empleado empleado = new Empleado();

            bool nombreValido = false;
            while (!nombreValido)
            {
                Console.WriteLine("Ingrese el nombre del empleado:");

                try
                {
                    empleado.Nombre = Console.ReadLine() ?? "";
                    nombreValido = true;
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            bool edadValida = false;
            while (!edadValida)
            {
                Console.WriteLine("Ingrese la edad del empleado:");

                if (int.TryParse(Console.ReadLine(), out int edadIngresada))
                {
                    try
                    {
                        empleado.Edad = edadIngresada;
                        edadValida = true;
                    }
                    catch (ArgumentException error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una edad numerica.");
                }
            }

            Console.WriteLine($"Empleado: {empleado.Nombre}, Edad: {empleado.Edad}");
            Console.WriteLine("Desea cambiar la edad del empleado? (s/n)");
            string respuesta = Console.ReadLine() ?? "";

            do
            {
                if (respuesta.ToLower() == "s")
                {
                    bool nuevaEdadValida = false;

                    while (!nuevaEdadValida)
                    {
                        Console.WriteLine("Ingrese la nueva edad del empleado:");

                        if (int.TryParse(Console.ReadLine(), out int nuevaEdad))
                        {
                            try
                            {
                                empleado.Edad = nuevaEdad;
                                nuevaEdadValida = true;
                            }
                            catch (ArgumentException error)
                            {
                                Console.WriteLine(error.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una edad numerica.");
                        }
                    }

                    Console.WriteLine($"Edad actualizada. Empleado: {empleado.Nombre}, Edad: {empleado.Edad}");
                    break;
                }
                else if (respuesta.ToLower() == "n")
                {
                    Console.WriteLine("No se realizaron cambios en la edad del empleado.");
                    break;
                }
                else
                {
                    Console.WriteLine("Respuesta no valida. Por favor, ingrese 's' o 'n'.");
                    respuesta = Console.ReadLine() ?? "";
                }
            }
            while (true);
        }
    }
}
