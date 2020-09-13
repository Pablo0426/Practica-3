using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Class1
    {
        public void Temp(double n)
        {
            double cel = (n - 32) * 5 / 9;
            Console.WriteLine("La coversion de °F a °C es: " + cel);
        }

        public void Money(double n)
        {
            double dolar = 58.29;
            double result = dolar * n;
            Console.Write("Conversion a pesos dominicanos: "+ result);
        }

        public void Dist(double m)
        {
            double Pies = m * 3.2808;
            Console.WriteLine("La conversion de metros a pies es: " +Pies);
        }
    }
}
