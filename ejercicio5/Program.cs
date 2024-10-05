using System;

public class Program
{
    public static void Main()
    {
        //declaracion de variables
        double importe1;
        double importe2;
        //Creamos los objetos, cuenta1 y cuenta2
        //Primero va el nombre de la clase de donde obtenemos los datos,luego creamos el nombre de la variable
        Cuenta cuenta1 = new Cuenta();
        Cuenta cuenta2 = new Cuenta();

        //tomamos valor por teclado

        Console.WriteLine("Ingrese un importe para la cuenta1");
        importe1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese un importe para la cuenta2");
        importe2 = Convert.ToDouble(Console.ReadLine());

        //Llamada a los métodos
        cuenta1.Acredita(importe1);
        cuenta2.Acredita(importe2);
     
        //mostrar un mensaje
        Console.WriteLine("El importe de la cuenta 1 es de: ");
        cuenta1.MostrarSaldo();
        Console.WriteLine("El importe de la cuenta 2 es de: ");
        cuenta2.MostrarSaldo();


    }
}

