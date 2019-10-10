using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // fuente: https://drive.google.com/file/d/1z9pZhZDjiV5D5GHdG3rKZ-_jd1GAXMtp/view
            #region FASE 1: Inicializar y mostrar variables int y string.
            string name = "Elijendru";
            string lastName1 = "Elmindru";
            string lastName2 = "Difodilobas";

            int day = 8;
            int month = 6;
            int year = 1911;

            Console.WriteLine(name + " " + lastName1 + " " + lastName2);
            Console.WriteLine(day + " / " + month + " / " + year);
            #endregion

            #region FASE 2: Calcular años entre TRASPAS y nacimiento.
            const int TRASPAS = 1948;

            int ageDifference = year - TRASPAS;
            if (ageDifference < 0) ageDifference= ageDifference *-1;

            Console.WriteLine(ageDifference);
            //TODO falta una variable
            #endregion

            #region FASE 3:
            //TODO
            #endregion

            #region FASE 4:
            //TODO
            #endregion
        }
    }
}
