using System;

public class Producto
{
    // declaro las variables
    public string? nombre;
    public double? precio = 0;
    public int cantidad = 0;
    public int precioTotal = 0;

    public string? IngresarNombre()
    {
        Console.WriteLine("Ingrese  el nombre del producto:  ");
        nombre = Console.ReadLine();
        return nombre;
    }
    public double? IngresarPrecio()
    {
        Console.WriteLine("Ingrese  el precio del producto:  ");
        precio = Convert.ToDouble(Console.ReadLine());
        return precio;
    }

    public int AgregarCantidad()
    {
        Console.WriteLine("Ingrese cantidad del producto:  ");
        cantidad = Convert.ToInt32(Console.ReadLine());
        return cantidad;
    }

    public void CalcularPrecioTotal()
    {
        if (precio.HasValue && cantidad > 0)
        {
            precioTotal = (int)(precio * cantidad);
        }
        else
        {
            Console.WriteLine("No se puede calcular el precio total. Por favor, ingrese un precio y cantidad válidos.");
        }
    }

    public void MostrarInformación()
    {
        Console.WriteLine("Nombre del producto:  {0}", nombre);
        Console.WriteLine("Precio unitario del producto:  {0}", precio);
        Console.WriteLine("Cantidad en stock del producto:  {0}", cantidad);
        Console.WriteLine("Valor total del stock:  {0}", precioTotal);
    }
}