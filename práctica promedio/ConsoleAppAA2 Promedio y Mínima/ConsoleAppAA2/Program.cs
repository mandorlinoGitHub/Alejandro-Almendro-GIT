using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppAA2
{
    class Program
    {
        public static string inputChosen;
        public static List<double> listScores = new List<double>();
        static void Main(string[] args)
        {
            WriteMenu();
        }
        static void WriteMenu()
        {
            Console.Clear();
            Console.WriteLine(
                         "¡Bienvenido a la fantástica app de almacenamiento de" +
                         " notas y cálculo de chorradillas!\n" +
                         "Menú de opciones:\n" +
                         "   1. Introducir notas\n" +
                         "   2. Ver notas introducidas\n" +
                         "   3. Ver promedio\n" +
                         "   4. Ver nota mínima\n" +
                         "   5. Ver nota máxima\n" +
                         "   x. Salir del programa");
            MenuControl();
        }
        static void MenuControl()
        {
            inputChosen = Console.ReadLine();

            switch (inputChosen)
            {
                case "1":
                    introScores();
                    break;
                case "2":
                case "3":
                case "4":
                case "5":
                    IfScores();
                    break;
                case "x":
                    Console.WriteLine("CHAU! (Presiona ENTER para salir.)");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("¡LO SIENTO, PERO NO CONOZCO ESA OPCIÓN!");
                    MenuControl();
                    break;
            }
        }
        static void introScores()
        {
            Console.Clear();
            bool escapeWord = false;
            while (escapeWord == false)
            {
                Console.WriteLine("Introduce la nota de un alumno, o \"x\" para salir:");

                string input = Console.ReadLine().Replace(".", ",");

                if (input == "x")
                {
                    escapeWord = true;
                }
                else
                {
                    double.TryParse(input, out double StudentScore);
                    if (StudentScore != 0)
                    {
                        listScores.Add(StudentScore);
                        Console.WriteLine("Almacenada correctamente.");
                    }

                    else
                    {
                        Console.WriteLine("El formato es incorrecto" +
                            " o la nota no puede ser 0:");
                    }
                }
            }
            WriteMenu();
        }
        static void ShowScores()
        {
            Console.Write($"Las {listScores.Count} notas introducidas son: ");
            foreach (double item in listScores)
            {
                Console.Write(item + "| ");
            }
            Console.WriteLine();
            MenuControl();
        }
        static void AvgScore()
        {
            double sumANDavg = 0;
            for (int i = 0; i < listScores.Count; i++)
            {
                sumANDavg += listScores[i];
            }
            sumANDavg = sumANDavg / listScores.Count;
            Console.WriteLine($"El promedio de las {listScores.Count} notas es: {sumANDavg}");
            MenuControl();
        }
        static void MinScore()
        {
            double minvalue = listScores[0];

            foreach (double i in listScores)
            {
                if (i < minvalue)
                {
                    minvalue = i;
                }
            }
            Console.WriteLine("La menor nota es: " + minvalue);
            MenuControl();
        }
        static void MaxScore()
        {
            double maxvalue = listScores[0];

            foreach (double i in listScores)
            {
                if (i > maxvalue)
                {
                    maxvalue = i;
                }
            }
            Console.WriteLine("La mayor nota es: " + maxvalue);
            MenuControl();
        }
        static void IfScores()
        {
            if (listScores.Count != 0)
            {
                switch (inputChosen)
                {
                    case "2":
                        ShowScores();
                        break;
                    case "3":
                        AvgScore();
                        break;
                    case "4":
                        MinScore();
                        break;
                    case "5":
                        MaxScore();
                        break;
                }
            }
            else
            { 
                Console.WriteLine("No se ha introducido ninguna nota aún.");
                MenuControl();
            }
        } 
    } 
}
