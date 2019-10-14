using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre (con caracteres alfanuméricos):");
            string input = Console.ReadLine();

            #region FASE 1: Crear y escribir array de caracteres.
            char[] nameArray = input.ToCharArray(0, input.Length);


            foreach(char i in nameArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region FASE 2: Convertir a lista, detectar si son consonante, vocal o número.
            List<char> nameList = nameArray.ToList();

            foreach(char i in nameList)
            {
                if (i >= 'A' && i <= 'Z' || i >= 'a' && i <= 'z')
                    if (i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U' || i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                        Console.WriteLine("\"" + i + "\"" + " es una vocal.");
                    else Console.WriteLine("\"" + i + "\"" + " es una consonante.");
                else if (i >= '0' && i <= '9')
                    Console.WriteLine(i + " ¡Los nombres de personas no contienen números!");
                else Console.WriteLine("\"" + i + "\"" + " no es un carácter alfanumérico");
            }
            Console.ReadLine();
            #endregion

            #region FASE 3: Guardar en diccionario
            Dictionary<char, string> charDictionary = new Dictionary<char, string>();

            foreach(char i in nameList)
            {
                string j = "aparece" + count+"veces.";
                charDictionary.Add<i; > 
            }

            #endregion

            #region FASE 4:
            //TODO
            #endregion
        }
    }
}
