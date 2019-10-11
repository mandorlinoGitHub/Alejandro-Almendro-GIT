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

            int birthDay = 8;
            int birthMonth = 6;
            int birthYear = 1986;

            Console.WriteLine(name + " " + lastName1 + " " + lastName2);
            Console.WriteLine(birthDay + " / " + birthMonth + " / " + birthYear);
            Console.WriteLine();
            #endregion

            #region FASE 2: Calcular años entre 1948 y nacimiento.
            const int leapYear1948 = 1948;
            const int leapYearPeriod = 4;
            int ageDifference = birthYear - leapYear1948;
            int countLeapYears = ageDifference / leapYearPeriod;

            Console.WriteLine(countLeapYears);
            Console.WriteLine();
            #endregion

            #region FASE 3: Listar años bisiestos y determinar si el año de nacimiento lo es.  
            string isLeapYear = "El año de nacimiento es bisiesto.";
            string isNotLeapYear = "El año de nacimiento no es bisiesto.";
            bool is_BD_LY_check;

            for (int i = leapYear1948;  i < birthYear;i += leapYearPeriod)
            {
                Console.WriteLine(i);
            }

            if (birthYear % leapYearPeriod == 0)
                is_BD_LY_check = true;
            else
                is_BD_LY_check = false;

            if (is_BD_LY_check == true)
                Console.WriteLine(isLeapYear);
            else
                Console.WriteLine(isNotLeapYear);
            Console.WriteLine();
            #endregion

            #region FASE 4: Imprimir toda la info.
            string fullName = $"{name} {lastName1} {lastName2}";
            string fullDate = $"{birthDay} / {birthMonth} / {birthYear}";

            Console.WriteLine(fullName);
            Console.WriteLine(fullDate);
            if (is_BD_LY_check == true)
                Console.WriteLine(isLeapYear);
            else
                Console.WriteLine(isNotLeapYear);
            #endregion 
        }
    }
}
