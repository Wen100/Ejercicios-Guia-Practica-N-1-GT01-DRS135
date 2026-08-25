using System;

namespace Ejercicio4
{
    /// <summary>
    /// Clase base reutilizable para representar un animal.
    /// El metodo HacerSonido es virtual para permitir polimorfismo y sobrescritura.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Emite el sonido generico de un animal.
        /// Las clases derivadas pueden sobrescribir este comportamiento.
        /// </summary>
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
}
