using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Class1
    {
        public string Nombre;
        public int Contra;

        public void Credenciales(string N, int C)
        {
            if (Nombre == "admin" && Contra == 1234)
            {
                Console.WriteLine("Verdadero");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas.");
            }
        }
    }
}
