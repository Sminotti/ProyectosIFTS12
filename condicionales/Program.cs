using System;
namespace condicionales
{
    public class Program
    {
        public static void Main()
        {
            int numero_1;
            int numero_2;

            Console.WriteLine("Ingrese dos numeros:");
            Console.WriteLine("Escriba el primer numero:");
            numero_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el primer numero:");
            numero_2 = Convert.ToInt32(Console.ReadLine());

            if (numero_1 == numero_2) { Console.WriteLine("{0}=={1}", numero_1, numero_2); }
            if (numero_1 <= numero_2) { Console.WriteLine("{0}<={1}", numero_1, numero_2); }
            if (numero_1 >= numero_2) { Console.WriteLine("{0}>={1}", numero_1, numero_2); }
            if (numero_1 != numero_2) { Console.WriteLine("{0}!={1}", numero_1, numero_2); }
            if (numero_1 < numero_2) { Console.WriteLine("{0}<{1}", numero_1, numero_2); }
            if (numero_1 > numero_2) { Console.WriteLine("{0}>{1}", numero_1, numero_2); }
        }
    }
}