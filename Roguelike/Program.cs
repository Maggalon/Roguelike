using System.Diagnostics.SymbolStore;
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
