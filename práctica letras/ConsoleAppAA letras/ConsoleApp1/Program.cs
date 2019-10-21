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
            string inputName = Console.ReadLine();

            #region FASE 1: Crear y escribir array de caracteres.
            Console.WriteLine("FASE 1:");
            char[] nameArray = inputName.ToCharArray(0, inputName.Length);


            foreach(char i in nameArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region FASE 2: Convertir a lista, detectar si son consonante, vocal o número.
            Console.WriteLine("FASE 2:");
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
            Console.WriteLine();
            #endregion

            #region FASE 3: Guardar en diccionario cada una y cuánto se repiten.
            Console.WriteLine("FASE 3:");
            Dictionary<char, int> CharCountDict = new Dictionary<char, int>();

            foreach (char item in nameList)
            {
                if (CharCountDict.ContainsKey(item))
                {
                    CharCountDict[item] += 1;
                }
                else
                {
                    CharCountDict.Add(item, 1);
                }
            }
            foreach (KeyValuePair<char,int> item in CharCountDict)
            {
                Console.WriteLine($"Key: {item.Key}    Iterations: {item.Value}");
            }
            Console.WriteLine();
            #endregion

            #region FASE 4: Crear otra lista y fusionarlas con un espacio en blanco entremedio.
            Console.WriteLine("Introduce tu apellido (con caracteres alfanuméricos):");
            string inputLastName = Console.ReadLine();

            var lastNameList = new List<char>() {' '};

            foreach (char item in inputLastName)
            {
                lastNameList.Add(item);
            }
            
            var fullNameList = new List<char>();
            fullNameList.AddRange(nameList);
            fullNameList.AddRange(lastNameList);


            var commaCount = 0;
            foreach (char item in fullNameList)
            {
                Console.Write(item);
                commaCount++;

                if (commaCount < fullNameList.Count)
                { 
                Console.Write(", ");
                }
                else Console.Write(".");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
