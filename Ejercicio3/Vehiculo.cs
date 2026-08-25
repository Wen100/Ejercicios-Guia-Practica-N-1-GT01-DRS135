using System;

namespace Ejercicio3
{
    /// <summary>
    /// Clase base que representa un vehiculo.
    /// Encapsula el estado de encendido y expone las operaciones comunes.
    /// </summary>
    public class Vehiculo
    {
        private bool encendido;

        /// <summary>
        /// Indica si el vehiculo esta encendido. Solo las clases derivadas pueden consultarlo.
        /// </summary>
        protected bool Encendido
        {
            get { return encendido; }
        }

        /// <summary>
        /// Enciende el vehiculo si aun no esta arrancado.
        /// </summary>
        public void Arrancar()
        {
            if (encendido)
            {
                Console.WriteLine("El vehiculo ya esta arrancado.");
                return;
            }

            encendido = true;
            Console.WriteLine("El vehiculo ha arrancado.");
        }

        /// <summary>
        /// Detiene el vehiculo si se encuentra en marcha.
        /// </summary>
        public void Detener()
        {
            if (!encendido)
            {
                Console.WriteLine("El vehiculo ya esta detenido.");
                return;
            }

            encendido = false;
            Console.WriteLine("El vehiculo se ha detenido.");
        }
    }
}
