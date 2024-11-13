using System;


public class SubirOnoCuota
{
    public int aprobados = 0;
    public int cont = 1;
    public int cursantes = 0;
    public int nota = 0;

    public void Aprobados()
    {
        Console.WriteLine("Ingrese cantidad de cursantes: ");
        cursantes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese 1 para aprobado o 2 para reprobado: ");
        while (cont <= cursantes)
        {
            Console.WriteLine("Ingrese la nota del estudiante {0}: ",cont);
            nota = Convert.ToInt32(Console.ReadLine());
            cont ++;
            if (nota == 1)
            {
                aprobados++;
            }
        }
        if (aprobados >= 8)
        {
            Console.Write("La cantidad de aprobados es: " + aprobados + " Hay que aumentar la cuota");
        }
    }
}