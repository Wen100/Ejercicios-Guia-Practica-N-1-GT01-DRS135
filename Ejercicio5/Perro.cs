using System;

namespace Ejercicio5
{
    /// <summary>
    /// Clase derivada en la herencia multinivel.
    /// Hereda Alimentar de <see cref="Mamifero"/> y sobrescribe HacerSonido de Animal.
    /// </summary>
    public class Perro : Mamifero
    {
        /// <summary>
        /// Sobrescribe el sonido heredado de Animal (ejercicio 4) a traves de Mamifero.
        /// </summary>
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau!");
        }
    }
}
