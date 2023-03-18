using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace rpg_console
{
    class Program : Fight
    {
        public Program(string name, int health, int armor, int damage) : base(name, health, armor, damage)
        {
        }

        static void Main(string[] args)
        {
            Fight player = new Fight("German", 100, 123, 1);
            Fight enemy = new Fight("Heroes of Might and Magic III", 11, 11, 11);
            Attack(player,enemy);

        }


    }
}