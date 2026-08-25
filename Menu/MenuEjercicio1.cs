using System;
using Ejercicio1;

namespace Menu
{
    /// <summary>
    /// Ejecuta el ejercicio 1: cuenta bancaria con saldo encapsulado.
    /// </summary>
    public class MenuEjercicio1
    {
        public void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 1: Abstraccion de datos - Cuenta bancaria\n");

            CuentaBancaria cuenta = new CuentaBancaria();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nQue desea hacer?");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Volver al menu principal");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"Saldo actual: ${cuenta.ObtenerSaldo():0.00}");
                        break;

                    case "2":
                        decimal deposito = LeerMonto("Ingrese el monto a depositar: ");
                        cuenta.Depositar(deposito);
                        Console.WriteLine("Deposito realizado correctamente.");
                        break;

                    case "3":
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

                    case "4":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }
            }
        }

        private static decimal LeerMonto(string mensaje)
        {
            decimal monto;

            do
            {
                Console.Write(mensaje);

                if (decimal.TryParse(Console.ReadLine(), out monto) && monto > 0)
                {
                    return monto;
                }

                Console.WriteLine("Ingrese un monto numerico mayor que cero.");
            }
            while (true);
        }
    }
}
