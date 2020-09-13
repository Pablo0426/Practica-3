using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantMil = 9;
            int Mil = 1000;

            int cantQuin = 19;
            int Quin = 500;

            int cantCi = 99;
            int Ci = 100;
            int Disponible = (cantMil * Mil) + (cantQuin * Quin) + (cantCi * Ci);
            int k;
            int q;
            int h;

            inicio:
            Console.WriteLine("Elija la opcion a efectuar\n\n" +
                "[1] Retiro\n" +
                "[2] Transaccion\n" +
                "[3] Salir");

            int op=int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    otro:
                    Console.WriteLine("Ingrese la cantidad a retirar");
                    int ret = int.Parse(Console.ReadLine());
                    if (ret > 10000)
                    {
                        Console.WriteLine("El monto ingresado exede a lo permitido\n");
                        Console.ReadKey();
                        goto otro;
                    }
                    else
                    {
                        if(Disponible > ret)
                        {
                            Disponible = Disponible - ret;
                            
                            Console.WriteLine("Retire su dinero.\n");
                            Console.WriteLine("RD$ disponible "+Disponible+ "\n");
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos este cajero no cuenta con dicha cantidad actualmente...");
                            Console.WriteLine("RD$ disponible " + Disponible+ "\n");
                        }
                    }
                    goto inicio;
                case 2:
                    otra:
                    Console.WriteLine("Ingrese el monto");
                    int tran = int.Parse(Console.ReadLine());
                    if (tran > 2000)
                    {
                        Console.WriteLine("El monto ingresado exede a lo permitido\n");
                        Console.ReadKey();
                        goto otra;
                    }
                    else
                    {
                        Console.WriteLine("Usted ha efectuado una transaccion de "+tran+" pesos");
                    }
                    goto inicio;
                case 3:
                    Console.WriteLine("Gracias por usar nuestros servicios!");
                    break;
                default:
                    Console.WriteLine("Esa opcion no existe...\n");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;
            }
            Console.ReadKey();
        }
    }
}
