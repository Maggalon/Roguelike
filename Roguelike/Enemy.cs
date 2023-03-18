using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace rpg_console
{
    internal class Enemy : Person
    {
        public Enemy(string name) : base("Bot", 100, 20, 5)
        {
        }
=======
namespace Roguelike
{
    public class Enemy : Entity
    {
        public Enemy(string name, int health, int lvl, int damage, int armor, int money, char symbol) : base(name, health, lvl, damage, armor, money, symbol) { }
>>>>>>> 1ccd0729b94219b4d2d68c73e6126784591e13be
    }
}
