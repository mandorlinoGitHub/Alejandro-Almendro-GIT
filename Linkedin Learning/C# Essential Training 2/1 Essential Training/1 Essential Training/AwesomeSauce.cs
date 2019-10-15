using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Essential_Training
{
    public class AwesomeSauce
    {
        public List<string> Sauces { get; set; }

        public AwesomeSauce()
        {
            Sauces = new List<String>();
        }

        public bool IsSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }
    }
}
