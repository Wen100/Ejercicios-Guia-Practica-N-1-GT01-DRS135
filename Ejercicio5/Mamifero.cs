using System;
using Ejercicio4;

namespace Ejercicio5
{
    /// <summary>
    /// Clase intermedia de la herencia multinivel.
    /// Reutiliza <see cref="Animal"/> del ejercicio 4 y agrega Alimentar.
    /// Jerarquia: Animal (ejercicio 4) -> Mamifero -> Perro.
    /// </summary>
    public class Mamifero : Animal
    {
        /// <summary>
        /// Alimenta al mamifero. Este metodo se hereda hacia las clases derivadas.
        /// </summary>
        public void Alimentar()
        {
            Console.WriteLine("El mamifero se esta alimentando.");
        }
    }
}
