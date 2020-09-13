using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla de multiplicacion del numero: ");
            
            for (int i = 5; i <= 1000; i = i+5)
            {
                Console.WriteLine("La tabla del multiplicacion de "+i+" es:");
                for (int i2 = 1; i2 <= 12;i2++)
                {
                    Console.Write(i + "x" + i2 + "=");
                    Console.Write(i * i2 + " \n");
                }
            }
            Console.ReadKey();
        }
    }
}
