using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_console
{
    internal class Enemy : Person
    {
        public Enemy(string name) : base("Bot", 100, 20, 5)
        {
        }
    }
}
