using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    public class Item
    {
        public string name { get; set; }
        public int price { get; set; }
        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
