
public class Cuenta
{
    //Aquí vamos a ingresar los atributos o variables de instancia
    double saldo = 50000; // el saldo lo tendria que obtenet desde la base de datos

    //Aquí van a ir los métodos Acredita y Mostrar Saldo

    public void Acredita(double unImporte)

    {
        saldo += unImporte;// esto es igual a saldo = saldo + unImporte
    }

    public void MostrarSaldo()
    {
        Console.WriteLine("El saldo de la cuenta: {0}", saldo);
    }
}
