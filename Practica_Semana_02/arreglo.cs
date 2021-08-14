using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Semana_02
{
    class arreglo
    { 
        static void Main()
        {
            // Declaracion de variable. 

            int estudiantesn;

            // DECLARACION DEL TAMAÑO DEL ARREGLO. 
            // Condicion do while para que el usaurio digite un dato valido. 
            do
            {
                Console.WriteLine("INGRESE EL NUMERO DE ESTUDIANTES QUE DESEA PROMEDIAR: ");
                estudiantesn = Convert.ToInt32(Console.ReadLine());
            } while (estudiantesn <= 0);

            // Arrays 
       
            string[] nombre = new string[estudiantesn];

                // Pedimos al usuarios los nombres de los estudiantes 

                for (int i = 0; i < nombre.Length; i++)
                {
                    Console.Write("INGRESAR NOMBRE DEL ESTUDIANTE {0}: ", i);
                    nombre[0] = Console.ReadLine();
                    Console.WriteLine(" ");

                    // Solicitar notas del estudiante. 

                    double[] notas = new double[3];

                    for (int j = 0; j < notas.Length; j++)
                    {
                        Console.Write("INGRESAR NOTA {0}: ", j);
                        notas[j] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(" ");
                    }

                    // Promedio. 

                    notas[0] = (notas[0] * 30) / 100;
                    notas[1] = (notas[1] * 35) / 100;
                    notas[2] = (notas[2] * 25) / 100;
                    double notaf = notas[0] + notas[1] + notas[2];
              
                
                Console.WriteLine("******************************************************************");
                Console.WriteLine("LA NOTA FINAL DEL ESTUDIANTE, {0}{1}{2}", nombre[0], " ES: ", notaf);
                if (notaf >= 6)
                {
                Console.WriteLine("----------------------------------------------------------APROBADO");

                }
                else
                {
                Console.WriteLine("---------------------------------------------------------REPROBADO"); 
                }
                Console.WriteLine("******************************************************************");
                Console.WriteLine(" ");


            }


                Console.ReadKey();
        }
    }
}
