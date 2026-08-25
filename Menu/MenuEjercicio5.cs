using System;

namespace Menu
{
    /// <summary>
    /// Ejecuta el ejercicio 5: herencia multinivel reutilizando Animal del ejercicio 4.
    /// </summary>
    public class MenuEjercicio5
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 5: Herencia multinivel - Animal / Mamifero / Perro\n");

            Ejercicio5.Perro perro = new Ejercicio5.Perro();
            Ejercicio4.Animal animalReutilizado = perro;

            Console.WriteLine("Reutilizacion: Perro del ejercicio 5 tratado como Animal del ejercicio 4.");
            animalReutilizado.HacerSonido();
            perro.Alimentar();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nQue desea hacer con el perro?");
                Console.WriteLine("1. Hacer sonido (metodo sobrescrito)");
                Console.WriteLine("2. Alimentar (metodo heredado de Mamifero)");
                Console.WriteLine("3. Volver al menu principal");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        perro.HacerSonido();
                        break;

                    case "2":
                        perro.Alimentar();
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
