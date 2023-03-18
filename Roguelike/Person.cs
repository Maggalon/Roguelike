using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_console
{
    internal class Person
    {
        public string name { get; set; }

        public int health;

        public int armor;

        public int damage;

        public Person(string name, int health, int armor, int damage)
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
            this.damage = damage;
        }

        public  void StatsShow()
        {
            Console.WriteLine($"Имя: {name} Здоровье: {health} Армор: {armor} Дамаг: {damage}");
        }
    }
}