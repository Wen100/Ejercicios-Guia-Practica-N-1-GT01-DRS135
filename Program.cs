using System;

public class Program
{
    public static void Main()
    {
        Menu.Menu menu = new Menu.Menu();

        bool continuar = true;
        while (continuar)
        {
            continuar = menu.Mostrar();
        }
    }
}
