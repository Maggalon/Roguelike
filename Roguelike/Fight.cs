using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace rpg_console
{
    internal class Fight : Person
    {
        public Fight(string name, int health, int armor, int damage) : base(name, health, armor, damage)
        {
        }
        
        public static void PrintText(Person player, Person enemy)
        {
            
            Random random = new Random(); int randomA = random.Next(1, 2);


            while (player.health > 0 || enemy.health > 0)
            {
                player.StatsShow();
                enemy.StatsShow();
                Thread.Sleep(1500);
                Console.Clear();
            }
        }

            
        

        public static void Attack(Person player, Person enemy)
        {
            DrawPerson a = new DrawPerson();
            Console.SetCursorPosition(0, 20);

            Thread animationThread = new Thread(() => a.idlePlayer("idleA_B_0.txt", "idleA_B_1.txt", "idleA_B_2.txt", "idleA_B_3.txt"));
            Console.Clear();
            Thread textThread = new Thread(() => PrintText(player, enemy));
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            animationThread.Start();
            textThread.Start();

            animationThread.Join();
            textThread.Join();

            if (player.health > enemy.health)
            {
                Console.WriteLine($"{player.name} победил");
            }
            else
            {
                Console.WriteLine($"{enemy.name} победил");

            }
        }
    }
}