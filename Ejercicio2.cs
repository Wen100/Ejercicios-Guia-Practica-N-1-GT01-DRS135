//Creacion de clase
using System;

public class Empleado
{
    // Variables (privadas ambas)
    private string nombre;
    private int edad;

    public Empleado()
    {
    }

    //Constructor
    public Empleado(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Setters y Getters para las variables
    public string Nombre
    {
        get { return nombre; }

        // Validcion
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

            //Validacion
            if (value <= 0 || value >= 100)
            {
                throw new ArgumentException("La edad debe ser mayor que 0 y menor que 100.");
            }
            edad = value;
        }
    }
}
