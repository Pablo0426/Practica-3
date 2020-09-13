using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
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

            Console.Write("Actualmente el cajero cuenta con ");
            Console.WriteLine((cantMil * Mil)+(cantQuin*Quin)+(cantCi*Ci)+" RD$\n" +
                cantMil+" billetes de "+Mil+"\n"+
                cantQuin + " billetes de " +Quin+"\n"+
                cantCi + " billetes de " +Ci);
            Console.ReadKey();
        }
    }
}
