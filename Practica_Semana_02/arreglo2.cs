using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Semana_02
{
    class arreglo2
    {
        static void Main(string[] args)
        {

            string[] nombre = new string[6];
            Console.WriteLine("FORMA DESORDENADA:");
            Console.WriteLine("INGRESAR NOMBRE DE FAMILIARES: ");
            Console.WriteLine("************************************************************");

            for (int i = 1; i < nombre.Length; i++)
            {
                Console.Write("FAMILIAR {0}: ", i);
                nombre[i] = Console.ReadLine();


            }

            Array.Sort(nombre);

            Console.WriteLine(" ");
            Console.WriteLine("FORMA ORDENADA:");
            for (int j = 1; j < nombre.Length; j++)
            {
                Console.WriteLine("FAMILIAR {0}: {1}", j, nombre[j]);
            }

            Array.Reverse(nombre);

            Console.WriteLine(" ");
            Console.WriteLine("FORMA DESORDENADA:");
            for (int k = 1; k < nombre.Length; k++)
            {
                Console.WriteLine("FAMILIAR {0}: {1}", k, nombre[k]);
            }




            Console.ReadKey();
        }

        }
}
