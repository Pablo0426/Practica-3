using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero de inicio");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un numero para finalizar");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine("El limite no puede ser 0");
            }
            else if (n2 < n1)
            {
                Console.WriteLine("El numero limite debe ser mayor al numero de inicio");
            }
            else
            {
                for (int i = n1; i <= n2; i++)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
