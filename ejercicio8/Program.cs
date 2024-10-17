using System;

class  Program
{
    static void Main()
    {

Producto  producto1 = new Producto();
Producto  producto2 = new Producto();

producto1.IngresarNombre();
producto1.IngresarPrecio();
producto1.AgregarCantidad();
producto1.CalcularPrecioTotal();

producto1.MostrarInformación();




    }

}

