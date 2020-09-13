using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos Numeros? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite los " + n + "numeros:");
            int[] num = new int[n];
            int suma = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                suma = suma + num[i];
            }
            Console.WriteLine("El total de numeros dados fue de:" + n);
            Console.WriteLine("La suma de todos los numeros es: " + suma);

            Console.ReadKey();
        }
    }
}
