using System;

namespace Menu
{
    /// <summary>
    /// Menu principal del programa. Permite elegir y ejecutar cada ejercicio.
    /// </summary>
    public class Menu
    {
        private readonly MenuEjercicio1 ejercicio1 = new MenuEjercicio1();
        private readonly MenuEjercicio2 ejercicio2 = new MenuEjercicio2();
        private readonly MenuEjercicio3 ejercicio3 = new MenuEjercicio3();
        private readonly MenuEjercicio4 ejercicio4 = new MenuEjercicio4();
        private readonly MenuEjercicio5 ejercicio5 = new MenuEjercicio5();

        /// <summary>
        /// Muestra las opciones y ejecuta el ejercicio seleccionado.
        /// </summary>
        /// <returns>false cuando el usuario decide salir; true para seguir mostrando el menu.</returns>
        public bool Mostrar()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  Guia Practica N.1 - Menu de ejercicios");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Ejercicio 1 - Abstraccion (Cuenta bancaria)");
            Console.WriteLine("2. Ejercicio 2 - Encapsulacion (Empleado)");
            Console.WriteLine("3. Ejercicio 3 - Herencia simple (Vehiculo / Coche)");
            Console.WriteLine("4. Ejercicio 4 - Polimorfismo (Animal)");
            Console.WriteLine("5. Ejercicio 5 - Herencia multinivel (Mamifero / Perro)");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opcion: ");

            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    ejercicio1.Ejecutar();
                    Pausar();
                    return true;

                case "2":
                    ejercicio2.Ejecutar();
                    Pausar();
                    return true;

                case "3":
                    ejercicio3.Ejecutar();
                    Pausar();
                    return true;

                case "4":
                    ejercicio4.Ejecutar();
                    Pausar();
                    return true;

                case "5":
                    ejercicio5.Ejecutar();
                    Pausar();
                    return true;

                case "6":
                    Console.WriteLine("Gracias por usar el sistema.");
                    return false;

                default:
                    Console.WriteLine("Opcion no valida. Intente de nuevo.");
                    Pausar();
                    return true;
            }
        }

        private static void Pausar()
        {
            Console.WriteLine("\nPresione Enter para volver al menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
