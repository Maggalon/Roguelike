using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    public class Sword : Item
    {
        public int damage;
        public Sword(string name, int price, int damage) : base(name, price)
        {
            this.damage = damage;
        }
    }
}
