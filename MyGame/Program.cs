using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int numEnemies;
            Enemy [] enemies;
            Random random = new Random();
            // Pedir ao utilizador o num de enimigos
            Console.Write("Insira nº de inimigos: ");
            numEnemies = int.Parse(Console.ReadLine());

            //para cada inimigo pedir ao utilizador o seu nome,
            //criar objeto inimigo e guardá-lo num array
            enemies = new Enemy[numEnemies];
            for(int i = 0; i < numEnemies; i++)
            {
                string name;
                Console.Write($"Insira nome do inimigo #{i}:");
                name = Console.ReadLine();
                enemies[i] = new Enemy(name);

                if(random.NextDouble() < 0.3)
                {
                    enemies[i].PickupPowerUp(PowerUp.Shield, 50);
                }
                else
                {
                    enemies[i].TakeDamage(random.Next(100));
                }
            }

            foreach(Enemy enemy in enemies)
            {
                Console.WriteLine($">>{enemy.GetName()}<< HP={enemy.GetHealth()} Shield={enemy.GetShield()}<<");
            }

        }
    }
}
