using System;
using System.Collections.Generic;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;

        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazymathProblem();
        }

        static int CrazymathProblem()
        {
            var income = 1000;
            for (var i=10; i >0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
