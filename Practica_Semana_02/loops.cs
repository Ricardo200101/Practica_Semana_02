using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Semana_02
{
    class loops
    {
        static void Main(string[] args) 
        {
            loopWhile();

            Console.ReadKey();
        }
        // While. 
        // Evalua la condicion y ejecuta las intrucciones. 
        // si la condicio es verdadera. 
        public static void loopWhile()
        {
            int[] nums = new int[3]; // Crear un arreglo. 

            //llenar arreglo

            nums[0] = 4;
            nums[1] = 22;
            nums[2] = 8;

            // imprimir los numeros utilizado while. 

            int i = 0, idw = 0;
            Console.WriteLine("IMPRIMIENDO CON WHILE: ");
            while (i < nums.Length)
            {
                Console.WriteLine("INDICE {0}: {1}", i, nums[i]);
                i++;
            }
            Console.WriteLine(" ");

            // Imprimir con ciclo do while
            // La condicion se evalua al final 

            Console.WriteLine("IMPRIMIENDO CON  DO WHILE: ");

            do
            {
                Console.WriteLine("INDICE {0}: {1}", idw, nums[idw]);
                idw++;
            } while (idw < nums.Length);
            Console.WriteLine(" ");

            // Imprimir con ciclo for 
            // Se comprueba la condicion primero y luego se ejecuta si la condiciones es verdadera. 

            Console.WriteLine("IMPRIMIENDO CON FOR: ");

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("INDICE {0}: {1}", j, nums[j]);
            }



        }
    }
}
