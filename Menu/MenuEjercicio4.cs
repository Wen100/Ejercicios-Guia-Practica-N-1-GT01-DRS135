using System;
using Ejercicio4;

namespace Menu
{
    /// <summary>
    /// Ejecuta el ejercicio 4: polimorfismo con una referencia de tipo Animal.
    /// </summary>
    public class MenuEjercicio4
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 4: Polimorfismo - Animal\n");

            Animal animal;
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nQue animal desea escuchar?");
                Console.WriteLine("1. Perro");
                Console.WriteLine("2. Gato");
                Console.WriteLine("3. Volver al menu principal");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        animal = new Perro();
                        animal.HacerSonido();
                        break;

                    case "2":
                        animal = new Gato();
                        animal.HacerSonido();
                        break;

                    case "3":
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
