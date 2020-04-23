using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy1 = new Enemy ("   Ractan");
            //Enemy enemy2 = new Enemy ("Rácten",100,100);
            Console.WriteLine(enemy1.GetName());
        }
    }
}
