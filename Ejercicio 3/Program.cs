using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usuario: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Contraseña: ");
            int cont = int.Parse(Console.ReadLine());

            Class1 user = new Class1();
            user.Nombre = nom;
            user.Contra = cont;
            user.Credenciales(nom, cont);

            Console.ReadKey();
        }
    }
}
