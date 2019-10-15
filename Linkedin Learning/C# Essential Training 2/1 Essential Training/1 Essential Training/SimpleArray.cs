using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Essential_Training
{
    public class SimpleArray
    {
        public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "leche","agua","galletas","zumo" };
        }

        public override string ToString()
        {
            return "There are " + GroceryList.Length + " and there are" + GroceryList.ToString();
        }
    }
}
