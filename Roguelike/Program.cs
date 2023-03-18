<<<<<<< HEAD
﻿using System;
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
=======
﻿using System.Diagnostics.SymbolStore;
using Roguelike;

public class Program
{
    static void Main()
    {
        Person ivan = new Person("Иван", 100, 1, 5, 5, 100, '@');
        Person yt = new Person("Ут", 100, 1, 10, 0, 100, '$');
        while (ivan.health != 0 && yt.health != 0)
        {
            Console.WriteLine("выберите что хотите: 1 - атака");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                yt.TakeDamage(ivan.damage);
            }
            ivan.TakeDamage(yt.damage);
            ivan.PrintCharacteristics();
            yt.PrintCharacteristics();
        }
    }
}
>>>>>>> 1ccd0729b94219b4d2d68c73e6126784591e13be
