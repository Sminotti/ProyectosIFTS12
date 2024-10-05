using System;
namespace condicionales
{
    public class Program
    {
        public static void Main()
        {
            int numero_1;
            int numero_2;
            int numero_3;
            int numero_4;
            int numero_5;
            int edad;
            
            // ejerciocios 1 y 2
            Console.WriteLine("Ingrese dos numeros:");
            Console.WriteLine("Escriba el primer numero:");
            numero_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero:");
            numero_2 = Convert.ToInt32(Console.ReadLine());

            if (numero_1 == numero_2) { Console.WriteLine("{0}=={1}", numero_1, numero_2); }
            if (numero_1 <= numero_2) { Console.WriteLine("{0}<={1}", numero_1, numero_2); }
            if (numero_1 >= numero_2) { Console.WriteLine("{0}>={1}", numero_1, numero_2); }
            if (numero_1 != numero_2) { Console.WriteLine("{0}!={1}", numero_1, numero_2); }
            if (numero_1 < numero_2) { Console.WriteLine("{0}<{1}", numero_1, numero_2); }
            if (numero_1 > numero_2) { Console.WriteLine("{0}>{1}", numero_1, numero_2); }

            // ejercicio 3
            // Escriba un programa que permita leer por teclado la edad de una persona y devuelva en que rango etario se encuentra.

            Console.WriteLine("Escriba su edad:");
            edad = Convert.ToInt32(Console.ReadLine());// ingreso la edad y lo convierto a numero
            if (edad <= 11) { Console.WriteLine("Niñez"); }
            if ((edad >= 12) && (edad <= 18)) { Console.WriteLine("Adolescencia"); }
            if ((edad >= 19) && (edad <= 30)) { Console.WriteLine("Juventud"); }
            if ((edad >= 30) && (edad <= 60)) { Console.WriteLine("Adultez"); }
            if (edad > 60) { Console.WriteLine("Jóvenes por siempre"); }

            // ejercicioo 4
            // Escriba un programa que permita leer por teclado 5 valores enteros positivos y calcule el promedio de ellos.

            Console.WriteLine("Ingrese 3 numero mas: ");
            Console.WriteLine("Escriba el tercer numero:");
            numero_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el cuarto numero:");
            numero_4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el quinto numero:");
            numero_5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El promedio de los 5 numero ingresados: " + numero_1 +"-"+ numero_2 +"-"+ numero_3 +"-"+ numero_4 +"-"+ numero_5 +" "+ " es: ");
            Console.WriteLine((numero_1 + numero_2 + numero_3 + numero_4 + numero_5) / 5);

        }
    }
}