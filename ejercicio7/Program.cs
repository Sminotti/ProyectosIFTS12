using System;


class Program
{
    static void Main()
    {
        string? unNombre;
        double unaCantHoras;
        double unaTarifa;

        Empleado empleado1 = new Empleado();

        Console.WriteLine("****************************");
        Console.WriteLine("Programa Empleado");
        Console.WriteLine("****************************");
        // asigno  los valores a las variables

        Console.WriteLine("Ingrese el nombre del empleado:");
        unNombre = Console.ReadLine();

        Console.WriteLine("Ingrese las horas trabajadas:");
        unaCantHoras = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tarifa x hora:");
        unaTarifa = Convert.ToDouble(Console.ReadLine());

        // llamo a los metodos

        empleado1.AsignarNombre(unNombre);
        empleado1.AsignarTarifa(unaTarifa);
        empleado1.AsignarHorasTrabajadas(unaCantHoras);

        Console.WriteLine("\n*******Mostrar datos del Empleado**********");
        Console.WriteLine("Nombre: {0}", empleado1.MostrarNombre());
        Console.WriteLine("Horas trabajadas: {0}", empleado1.MostrarHoras());
        Console.WriteLine("Tarifa x hora: {0}", empleado1.MostrarTarifa());
        Console.WriteLine("Sueldo Neto: {0}", empleado1.MostrarSueldo());
        Console.WriteLine("*******************************************");

    }
}
