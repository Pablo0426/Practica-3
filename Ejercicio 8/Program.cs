using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el salario actual del empleado: ");
            double sueldo = double.Parse(Console.ReadLine());

            double ARS = 0.0304;
            double AFP = 0.0287;
            double calARS;
            double calAFP;
            double calISR;

            //Calculo del SFS/ARS segun el sueldo
            if (sueldo > 134820)
            {
                calARS = 134820 *ARS;
                Console.WriteLine("El calculo de la ARS es de: " + calARS);
            }
            else
            {
                calARS  =sueldo * ARS;
                Console.WriteLine("El calculo de la ARS es de: " + calARS);
            }
            //Calculo del AFP segun el sueldo
            if (sueldo > 269640)
            {
                calAFP = 269640 * AFP;
                Console.WriteLine("El calculo de la AFP es de: " + calAFP);
            }
            else
            {
                calAFP = sueldo * AFP;
                Console.WriteLine("El calculo de la AFP es de: " + calAFP);
            }
            //Calculo del ISR segun el sueldo
            if ((sueldo - calAFP - calARS) >72260.25)
            {
                calISR = ((sueldo - calAFP - calARS - 72260.25) * 0.25) + 6648;
                Console.WriteLine("El calculo del ISR es de: "+ calISR);
            }
            else if ((sueldo - calAFP - calARS) > 52027.42)
            {
                calISR = ((sueldo - calAFP - calARS - 52027.42) * 0.20) + 2601.33;
                Console.WriteLine("El calculo del ISR es de: " + calISR);
            }
            else if ((sueldo - calAFP - calARS) > 34685)
            {
                calISR = (sueldo - calAFP - calARS - 34685) * 0.15;
                Console.WriteLine("El calculo del ISR es de: " + calISR);
            }
            else
            {
                calISR = 0;
                Console.WriteLine("El calculo del ISR es de: " + calISR);
            }
            double SueldoN = sueldo - calAFP - calARS - calISR;
            Console.WriteLine("El sueldo neto es: "+SueldoN);
            Console.ReadKey();
        }
    }
}
