using System;

namespace Ejercicio2
{
    /// <summary>
    /// Representa un empleado. Nombre y edad se protegen con encapsulacion
    /// y se validan al asignarse mediante propiedades.
    /// </summary>
    public class Empleado
    {
        private string nombre;
        private int edad;

        public Empleado()
        {
        }

        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nombre vacio o no valido.");
                }

                nombre = value;
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value <= 0 || value >= 100)
                {
                    throw new ArgumentException("La edad debe ser mayor que 0 y menor que 100.");
                }

                edad = value;
            }
        }
    }
}
