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
    public class DrawPerson
    {
        public  void idlePlayer(string file_1, string file_2, string file_3, string file_4)
        {
            string fileC_1 = File.ReadAllText(file_1);
            string fileC_2 = File.ReadAllText(file_2);
            string fileC_3 = File.ReadAllText(file_3);
            string fileC_4 = File.ReadAllText(file_4);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(fileC_1);
                Thread.Sleep(1500);
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                Thread.Sleep(1500);
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                Thread.Sleep(1500);
                Console.Clear();

                Console.SetCursorPosition(0, 0);
                Thread.Sleep(1500);
                Console.Clear();

            }
        }
    }
}
