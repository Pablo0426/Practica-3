using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero: ");
            int n = int.Parse(Console.ReadLine());

            Class1 clase = new Class1();
            clase.doble(n);

            Console.ReadKey();
        }
    }
}
