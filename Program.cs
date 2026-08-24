using System;

public class Program
{
    public static void Main(string[] args)
    {

        // INICIO Ejercicio N°1-----------------------------------------------

        //Creacion de la instancia de la clase
        CuentaBancaria cuenta = new CuentaBancaria();

        //Booleano para el bucle
        bool salir = false;

        //Ciclo While para controlar el menu
        while (!salir)
        {
            //Menu
            Console.WriteLine("\nQue desea hacer?");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Retirar");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            //Leer la opción del usuario
            string opcion = Console.ReadLine() ?? "";

            //Switch para controlar las opciones del menu
            switch (opcion)
            {
                case "1": //Consulta
                    Console.WriteLine($"Saldo actual: ${cuenta.ObtenerSaldo():0.00}");
                    break;

                case "2": //Deposito de dinero
                    decimal deposito = LeerMonto("Ingrese el monto a depositar: ");
                    cuenta.Depositar(deposito);
                    Console.WriteLine("Depósito realizado correctamente.");
                    break;

                case "3": //Retiro de dinero
                    decimal retiro = LeerMonto("Ingrese el monto a retirar: ");

                    if (cuenta.Retirar(retiro))
                    {
                        Console.WriteLine("Retiro realizado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Fondos insuficientes.");
                    }
                    break;

                case "4": //Salida del menu
                    salir = true;
                    Console.WriteLine("Gracias por usar el sistema.");
                    break;

                default: // Si la opcion no es corecta o valida
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }

        //Validacion de montos para depositos y retiros
        decimal LeerMonto(string mensaje)
        {
            decimal monto;

            do
            {
                Console.Write(mensaje);

                if (decimal.TryParse(Console.ReadLine(), out monto) && monto > 0)
                {
                    return monto;
                }

                Console.WriteLine("Ingrese un monto numérico mayor que cero.");
            }
            while (true);
        }

        // FIN Ejercicio N°1-----------------------------------------------

    // INICIO Ejercicio N°2-----------------------------------------------
    //Creacion de la instancia de la clase
    Empleado empleado = new Empleado();

    //Variables para nombre y edad de empleado
    bool nombreValido = false;
    while (!nombreValido)
    {
        Console.WriteLine("\nIngrese el nombre del empleado:");

        try
        {
            empleado.Nombre = Console.ReadLine() ?? "";
            nombreValido = true;
        }
        catch (ArgumentException error)
        {
            Console.WriteLine(error.Message);
        }
    }

    bool edadValida = false;
    while (!edadValida)
    {
        Console.WriteLine("Ingrese la edad del empleado:");

        if (int.TryParse(Console.ReadLine(), out int edadIngresada))
        {
            try
            {
                empleado.Edad = edadIngresada;
                edadValida = true;
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
        }
        else
        {
            Console.WriteLine("Ingrese una edad numérica.");
        }
    }
    
    //MOstrar informacion actual
    Console.WriteLine($"Empleado: {empleado.Nombre}, Edad: {empleado.Edad}");

    //Consultar por cambio de edad
    Console.WriteLine("Desea cambiar la edad del empleado? (s/n)");
    string respuesta = Console.ReadLine() ?? "";
    
    //Validacion (en esta ocasion adentro de main)
        do
        {
            if (respuesta.ToLower() == "s")
            {
                bool nuevaEdadValida = false;

                while (!nuevaEdadValida)
                {
                    Console.WriteLine("Ingrese la nueva edad del empleado:");

                    if (int.TryParse(Console.ReadLine(), out int nuevaEdad))
                    {
                        try
                        {
                            empleado.Edad = nuevaEdad;
                            nuevaEdadValida = true;
                        }
                        catch (ArgumentException error)
                        {
                            Console.WriteLine(error.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una edad numérica.");
                    }
                }

                Console.WriteLine($"Edad actualizada. Empleado: {empleado.Nombre}, Edad:{empleado.Edad}");
                break;
            }
            else if (respuesta.ToLower() == "n")
            {
                Console.WriteLine("No se realizaron cambios en la edad del empleado.");
                break;
            }
            else
            {
                Console.WriteLine("Respuesta no válida. Por favor, ingrese 's' o 'n'.");
                respuesta = Console.ReadLine() ?? "";
            }
        }
        while (true);
        // FIN Ejercicio N°2-----------------------------------------------
    }
     



}
