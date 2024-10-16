using System;

public class Program
{
    public static void Main()
    {
        //Declaración de Variables
        string? unaEspecie;
        string? unNombre;
        DateTime unaFNac;

        Console.WriteLine("****************************");
        Console.WriteLine("Programa Mis Mascotas");
        Console.WriteLine("****************************");

        //Creación de objetos
        Mascota mascota1 = new Mascota();
        Mascota mascota2 = new Mascota();
        Mascota mascota3 = new Mascota();

        // Solicitar el ingreso de datos por teclado para cada una de las mascotas
        //Para la Mascota 1
        Console.WriteLine("Ingrese la especie de la Mascota1");
        unaEspecie = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre de la Mascota1");
        unNombre = Console.ReadLine();
        Console.WriteLine("Ingrese la fecha de nacimiento de la Mascota1 en formato (DD-MM-AAAA)");
        unaFNac = Convert.ToDateTime(Console.ReadLine());


        mascota1.AsignarEspecie(unaEspecie);
        mascota1.PonerNombre(unNombre);
        mascota1.AsignarFNac(unaFNac);

        //Para la Mascota 2
        Console.WriteLine("Ingrese la especie de la Mascota2");
        unaEspecie = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre de la Mascota2");
        unNombre = Console.ReadLine();
        Console.WriteLine("Ingrese la fecha de nacimiento de la Mascota2 en formato (DD-MM-AAAA)");
        unaFNac = Convert.ToDateTime(Console.ReadLine());

        mascota2.AsignarEspecie(unaEspecie);
        mascota2.PonerNombre(unNombre);
        mascota2.AsignarFNac(unaFNac);

        //Para la mascota 3
        Console.WriteLine("Ingrese la especie de la Mascota3");
        unaEspecie = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre de la Mascota3");
        unNombre = Console.ReadLine();
        Console.WriteLine("Ingrese la fecha de nacimiento de la Mascota3 en formato (DD-MM-AAAA)");
        unaFNac = Convert.ToDateTime(Console.ReadLine());

        mascota3.AsignarEspecie(unaEspecie);
        mascota3.PonerNombre(unNombre);
        mascota3.AsignarFNac(unaFNac);

        // Mostrar datos de las mascotas
        Console.WriteLine("***********Mascota 1***********");
        mascota1.MostrarEspecie();
        mascota1.MostrarNombre();
        mascota1.MostrarFNac();
        mascota1.MostrarDatos();

        Console.WriteLine("***********Mascota 2***********");
        mascota2.MostrarEspecie();
        mascota2.MostrarNombre();
        mascota2.MostrarFNac();
        mascota2.MostrarDatos();

        Console.WriteLine("***********Mascota 3***********");
        mascota3.MostrarEspecie();
        mascota3.MostrarNombre();
        mascota3.MostrarFNac();
        mascota3.MostrarDatos();
    }

}
