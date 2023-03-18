using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_console
{
    internal class Player : Person
    {
        public Player(string name) : base(name, 100, 20, 10)
        {
        }
    }
}
