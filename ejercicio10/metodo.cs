using System;

public class Promedio

{
    public int suma = 0;
    public int cont = 1;
    public int num = 0;
    public int promedio = 0;

    public void PromedioAlumnos()
    {
        Console.WriteLine("Ingrese las notas correspon dientes: ");
        while (cont <= 10)
        {
            Console.WriteLine("Ingrese el valor de la nota {0}: ", cont);
            num = Convert.ToInt32(Console.ReadLine());
            suma = suma + num;
            promedio = suma / cont;
            cont++;
        }
Console.WriteLine("El promedio de la clase es : {0}", promedio);
    }
 }   