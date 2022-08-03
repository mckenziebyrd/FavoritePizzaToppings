using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritePizzaToppings
{
    internal class Pizza
    {
        //map - refers to the process of making a 1-to-1 relationship between object properties
        public List<string> Toppings { get; set; }
        public string Size { get; set; }


        public override string ToString()
        {
            return this.Toppings[0].ToString();
        }
    }
}