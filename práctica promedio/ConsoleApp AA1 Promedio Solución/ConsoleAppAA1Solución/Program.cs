using System;
using System.Collections.Generic;

namespace ConsoleAppAA1Solución
{
    class Program
    {
        static string Escape = "p"; 
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa para gestión de alumnos.");
            Console.WriteLine("Introduce las notas de los alumno.s");

            var notasDeAlumnos = new List<double>();//HAY QUE AGREGAR EL NAMESPACE SYSTEM.COLLECTION.GENERIC
            var seguir = true;

            while (seguir)
            {
                Console.WriteLine($"Nota del alumno {notasDeAlumnos.Count +1}:");
                var notaString = Console.ReadLine();

                if (notaString == Escape)
                {
                    seguir = false;
                }
                else 
                {
                    var nota = 0.0;

                    if (double.TryParse(notaString.Replace(".", ","), out nota))//EL REPLACE ES OPCIONAL, ES PARA EVITAR QUE SE USE EL DECIMAL INCORRECTO
                        //EL OUT FUNCIONA DESPUÉS DE QUE EL TRYPARSE HAYA CORROBORADO QUE EL STRING ES UN DOUBLE,
                        //Y SU FUNCIÓN ES QUE EL STRING PARSEADO A NÚMERO SE ASIGNE A LA VARIABLE NOTA. DE HECHO,
                        //SE PODRÍA DECLARAR LA VARIABLE NOTA DIRECTAMENTE DENTRO DEL TRYPARSE, SI SE LE AGREGA
                        // EL TIPO DE VARIABLE (DOUBLE), ENTONCES SE PODRIA BORRAR LA LÍNEA 28.
                    {
                        notasDeAlumnos.Add(nota);
                    }
                    else
                    {
                        Console.WriteLine("La nota introducida es incorrecta!");
                    }
                }
            }

            var suma = 0.0;

            for (var i = 0; i < notasDeAlumnos.Count; i++)
            {
                suma += notasDeAlumnos[i];
            }

            var average = suma / notasDeAlumnos.Count;
            Console.WriteLine("La media de los exámenes es {0}", average);
        }
    }
}
