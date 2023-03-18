using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    public class Person : Entity
    {
        public Person(string name, int health, int lvl, int damage, int armor, int money, char symbol) : base(name, health, lvl, damage, armor, money, symbol) { }
    }
}
