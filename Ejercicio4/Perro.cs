using System;

namespace Ejercicio4
{
    /// <summary>
    /// Especializacion de <see cref="Animal"/> que sobrescribe el sonido.
    /// </summary>
    public class Perro : Animal
    {
        /// <summary>
        /// Emite el ladrido del perro.
        /// </summary>
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau!");
        }
    }
}
