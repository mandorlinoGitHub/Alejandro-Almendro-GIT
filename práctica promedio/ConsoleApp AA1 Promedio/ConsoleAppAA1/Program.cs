using System;

namespace ConsoleAppAA1
{
    class Program
    {
        static void Main(string[] args) //meter notas hasta meter un caracter y que te de la media
        {
            double sumaNotas = 0;
            int contadorNotas = 0;

            Console.WriteLine($"Hola, introduce una nota del 1 al 9, o presiona \"p\" para saber el promedio:");
            ConsoleKeyInfo input = Console.ReadKey();
//NO ENTIENDO CONSOLEKEYINFO
            string inputString = input.KeyChar.ToString();
//NO ENTIENDO KEYCHAR NI EL ORDEN DE LOS PUNTOS
//QUIERO HACER ESTOS DOS PASOS EN UNA LÍNEA

            if (char.IsDigit(input.KeyChar))
//NO ENTIENDO CHAR.ISDIGIT
            {
                sumaNotas = int.Parse(inputString);
                contadorNotas = 1;
            }
            else if (inputString == "p")
            {
                Console.WriteLine();    
            }
            else
            {
                Console.WriteLine("El carácter introducido no es válido.");
            }

            Console.WriteLine($"  Hay {contadorNotas} almacenadas y su suma es {sumaNotas}");

            while (inputString != "p")
            {
                Console.WriteLine($" Introduce otra nota o presiona \"p\" para saber el promedio:");
                input = Console.ReadKey();
                inputString = input.KeyChar.ToString();

                if (char.IsDigit(input.KeyChar))
                {
                    sumaNotas += int.Parse(inputString);
                    ++contadorNotas;
                }
                else if (inputString == "p")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("El carácter introducido no es válido.");
                }

                Console.WriteLine($"  Hay {contadorNotas} almacenadas y su suma es {sumaNotas}");
            }
            if (contadorNotas > 0)
            {
                double promedioNotas = sumaNotas / contadorNotas;
                Console.WriteLine("El promedio es: " + promedioNotas);
            }
            else 
            {
                Console.WriteLine("No introdujiste ninguna nota.");
            }




        }
    }
}
