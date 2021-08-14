using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Semana_02
{
    class coleccion
    {
        static void Main(string[] args)
        {
            // Diccionario. 
            // Tipo de coleccion generica de pares: claves: valor: 
            // Las claves deben ser unicas dentro de una coleccion 

            // Definimos el diccionario.
            Dictionary<String, int> familia = new Dictionary<string, int>();

            // Agregamos los datos. 
            familia.Add("Yaneth", 36);
            familia.Add("Rodrigo", 15);
            familia.Add("Ricardo", 20);
            familia.Add("Marina", 20);
            familia.Add("Melqui", 8);

            // Mostrar en pantalla. 

            foreach (KeyValuePair<string, int> familiar in familia)
            {
                Console.WriteLine("NOMBRE: {0}, EDAD: {1}", familiar.Key, familiar.Value);
            }


            Console.WriteLine(" ");
            // Ordenamos el diccionario. 
            var list = familia.Keys.ToList();
            list.Sort();
            Console.WriteLine("Diccionario ordenado: ");

            foreach (var item in list)
            {
                Console.WriteLine("NOMBRE: {0}, EDAD: {1}", item, familia[item]);
            }




            Console.ReadKey();


        }
    }
}
