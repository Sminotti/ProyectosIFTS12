using System;

public class UsoWhile
{
    public int cont = 1;
    public int numero = 0;
    public int suma = 0;

    public void ingresar5numeros()
    {
        Console.WriteLine("Ingrese 5 numeros:");
        while (cont <= 5)

        {
            Console.WriteLine("Ingrese el numero {0}:", cont);
            numero = Convert.ToInt32(Console.ReadLine());
            suma = numero + suma;
            
            cont++;
        }
        Console.WriteLine("La suma total de los valores ingresados es: {0}", suma);
    }

}
