using System;
using Ejercicio3;

namespace Menu
{
    /// <summary>
    /// Ejecuta el ejercicio 3: herencia simple entre Vehiculo y Coche.
    /// </summary>
    public class MenuEjercicio3
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 3: Herencia simple - Vehiculo / Coche\n");

            Coche coche = new Coche();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nQue desea hacer con el coche?");
                Console.WriteLine("1. Arrancar");
                Console.WriteLine("2. Detener");
                Console.WriteLine("3. Conducir");
                Console.WriteLine("4. Volver al menu principal");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        coche.Arrancar();
                        break;

                    case "2":
                        coche.Detener();
                        break;

                    case "3":
                        coche.Conducir();
                        break;

                    case "4":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
