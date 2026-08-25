using System;

namespace Ejercicio3
{
    /// <summary>
    /// Clase derivada de <see cref="Vehiculo"/>.
    /// Reutiliza Arrancar y Detener, y agrega la operacion Conducir.
    /// </summary>
    public class Coche : Vehiculo
    {
        /// <summary>
        /// Pone el coche en marcha. Requiere que el vehiculo este arrancado.
        /// </summary>
        public void Conducir()
        {
            if (!Encendido)
            {
                Console.WriteLine("No se puede conducir. Primero debe arrancar el coche.");
                return;
            }

            Console.WriteLine("El coche esta en marcha.");
        }
    }
}
