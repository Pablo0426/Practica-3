using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.WriteLine("Elija una opcion segun el numero.\n\n" +
                "[1] Convertir de Grados a Fahrenheit\n" +
                "[2] Convertir de Dolares a Pesos\n" +
                "[3] Convertir de Metros a Pies\n" +
                "[4] Salir");
            Class1 class1;
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Digite la temperatura en °F:");
                    double far = double.Parse(Console.ReadLine());
                    class1 = new Class1();
                    class1.Temp(far);
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;
                case 2:
                    Console.Write("Digite el monto en dolares: ");
                    double dolar = double.Parse(Console.ReadLine());
                    class1 = new Class1();
                    class1.Money(dolar);
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;
                case 3:
                    Console.WriteLine("Introduzca la distacia en metros: ");
                    double metros = double.Parse(Console.ReadLine());
                    class1 = new Class1();
                    class1.Dist(metros);
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;
                case 4:
                    Console.WriteLine("Gracias por usar nuestro Software.");
                    break;
                default:
                    Console.WriteLine("Esa opcion no esta en la lista...");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;
            }
            Console.ReadKey();
        }
    }
}
