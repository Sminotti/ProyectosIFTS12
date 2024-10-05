using System;


public class Mascota
{
    //Declaración de variables
    string? especie;
    string? nombre;
    DateTime FNac;

    //Declaración de Métodos

    public void AsignarEspecie(string unaEspecie)
    {
        especie = unaEspecie;
    }

    public string? MostrarEspecie()
    {
        return especie;
    }

    public void PonerNombre(string unNombre)
    {
        nombre = unNombre;
    }

    public string? MostrarNombre()
    {
        return nombre;
    }

    public void AsignarFNac(DateTime unaFecha)
    {
        FNac = unaFecha;
    }
    public string? MostrarFNac()
    {
        return FNac.ToString("dd-MM-yyyy");
    }

    public int CalcularEdad()
    {
        int edad = DateTime.Now.Year - FNac.Year;
        if (DateTime.Now.Year < FNac.Year)
        {
            edad--; //edad = edad -1
        }
        return edad;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Mi Mascota es de especie: {0}", especie);
        Console.WriteLine("El nombre de mi Mascota es :{0}", nombre);
        Console.WriteLine("La Fecha de Nacimiento es: {0}", FNac.ToString("dd-MM-yyyy"));
        Console.WriteLine("Su edad es de {0} años", CalcularEdad());

    }
}

