using System;

public class Empleado
{

    // declaro las variables
    string? nombre;
    double? horasTrabajadas;
    double? tarifaPorHora;

    // creo los metodos
    // asigno valores a las variables
    public void AsignarNombre(string unNombre)
    {
        nombre = unNombre;
    }

    public void AsignarTarifa(double unaTarifa)
    {
        tarifaPorHora = unaTarifa;
    }
    public void AsignarHorasTrabajadas(double unaCantHoras)
    {
        horasTrabajadas = unaCantHoras;
    }

    public string? MostrarNombre()
    {
        return nombre;
    }

    public double? MostrarHoras()
    {
        return horasTrabajadas;
    }

    public double? MostrarTarifa()
    {
        return tarifaPorHora;
    }

    public double? MostrarSueldo()
    {
       // Verifico que horasTrabajadas y tarifaPorHora no sean nulos antes de calcular el sueldo
        if (horasTrabajadas.HasValue && tarifaPorHora.HasValue)
        {
            return (horasTrabajadas.Value * tarifaPorHora.Value) * 0.17; // 17% de sueldo
        }
        return null; // Retorno null si no se puede calcular el sueldo
    }

}