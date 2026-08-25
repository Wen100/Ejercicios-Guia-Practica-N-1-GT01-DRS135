using System;

namespace Ejercicio4
{
    /// <summary>
    /// Especializacion de <see cref="Animal"/> que sobrescribe el sonido.
    /// </summary>
    public class Gato : Animal
    {
        /// <summary>
        /// Emite el maullido del gato.
        /// </summary>
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maulla: ¡Miau!");
        }
    }
}
