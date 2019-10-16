using System;

namespace ConsoleAppAA_ciudades
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FASE 1: Introducir nombres de ciudades y mostrarlas en pantalla
            Console.WriteLine("FASE 1:");
            Console.WriteLine();

            string ciudad1 = null;
            string ciudad2 = null;
            string ciudad3 = null;
            string ciudad4 = null;
            string ciudad5 = null;
            string ciudad6 = null;

            Console.WriteLine("Por favor, introduce el nombre de seis ciudades:");
            Console.Write("ciudad 1: ");
            ciudad1 = Console.ReadLine();
            Console.Write("ciudad 2: ");
            ciudad2 = Console.ReadLine();
            Console.Write("ciudad 3: ");
            ciudad3 = Console.ReadLine();
            Console.Write("ciudad 4: ");
            ciudad4 = Console.ReadLine();
            Console.Write("ciudad 5: ");
            ciudad5 = Console.ReadLine();
            Console.Write("ciudad 6: ");
            ciudad6 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Has introducido:\n" + ciudad1 + ", " + ciudad2 + ", " + ciudad3 + ", " + ciudad4 + ", " + ciudad5 + " y " + ciudad6 + ".");
            ciudad1 = "Barcelona";
            ciudad2 = "Madrid";
            ciudad3 = "Valencia";
            ciudad4 = "Málaga";
            ciudad5 = "Cádiz";
            ciudad6 = "Santander";
            Console.WriteLine("Gracias por perder tu tiempo, pero de ahora en adelante usaremos:\n" + ciudad1 + ", " + ciudad2 + ", " + ciudad3 + ", " + ciudad4 + ", " + ciudad5 + " y " + ciudad6 + ".");
            Console.WriteLine();
            #endregion

            #region FASE 2:  Guardarlas en un array ordenado alfabéticamente.
            Console.WriteLine("FASE 2:");
            Console.WriteLine();

            string[] arrayCiudades = new string[6] { ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 };
            Array.Sort(arrayCiudades);
            Console.WriteLine($"Las ciudades en orden alfabético son: {string.Join(", ", arrayCiudades)}");
            Console.WriteLine();
            #endregion

            #region FASE 3: Cambiar A por 4 y guardar en nuevo array.
            Console.WriteLine("FASE 3:");
            Console.WriteLine();

            string[] arrayCiudadesModificadas = new string[6];
            arrayCiudades.CopyTo(arrayCiudadesModificadas, 0);

            for (int i = 0; i < arrayCiudadesModificadas.Length; i++)
            {
                arrayCiudadesModificadas[i]= arrayCiudadesModificadas[i].Replace('a', '4');
                arrayCiudadesModificadas[i] = arrayCiudadesModificadas[i].Replace('á', '4');
                arrayCiudadesModificadas[i] = arrayCiudadesModificadas[i].Replace('A', '4');
                arrayCiudadesModificadas[i] = arrayCiudadesModificadas[i].Replace('Á', '4');
            }

            Array.Sort(arrayCiudadesModificadas);
            Console.WriteLine($"Las ciudades en orden alfabético con '4' en vez de 'a' son: {string.Join(", ", arrayCiudadesModificadas)}");
            Console.WriteLine();


            #endregion

            #region FASE 4:
            Console.WriteLine("FASE 4:");
            Console.WriteLine();
            
            var arrayCiudad1 = new char[arrayCiudades[0].Length];
            var arrayCiudad2 = new char[arrayCiudades[1].Length];
            var arrayCiudad3 = new char[arrayCiudades[2].Length];
            var arrayCiudad4 = new char[arrayCiudades[3].Length];
            var arrayCiudad5 = new char[arrayCiudades[4].Length];
            var arrayCiudad6 = new char[arrayCiudades[5].Length];

            arrayCiudad1 = arrayCiudades[0].ToCharArray();
            arrayCiudad2 = arrayCiudades[1].ToCharArray();
            arrayCiudad3 = arrayCiudades[2].ToCharArray();
            arrayCiudad4 = arrayCiudades[3].ToCharArray();
            arrayCiudad5 = arrayCiudades[4].ToCharArray();
            arrayCiudad6 = arrayCiudades[5].ToCharArray();

            Array.Reverse(arrayCiudad1);
            Array.Reverse(arrayCiudad2);
            Array.Reverse(arrayCiudad3);
            Array.Reverse(arrayCiudad4);
            Array.Reverse(arrayCiudad5);
            Array.Reverse(arrayCiudad6);

            Console.WriteLine(string.Join(", ", arrayCiudad1));
            Console.WriteLine(string.Join(", ", arrayCiudad2));
            Console.WriteLine(string.Join(", ", arrayCiudad3));
            Console.WriteLine(string.Join(", ", arrayCiudad4));
            Console.WriteLine(string.Join(", ", arrayCiudad5));
            Console.WriteLine(string.Join(", ", arrayCiudad6));

            Console.ReadLine();
            #endregion
        }
    }
}
