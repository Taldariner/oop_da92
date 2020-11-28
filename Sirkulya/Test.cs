using System;
using System.Collections.Generic;

namespace Game
{
    class Test
    {
        static void Main(string[] args)
        {
            Player player = new Player("PussyFucker69", 1000, 69, 20);
            Mob mob1 = new Mob("Slime", 100, 30, 0);
            Mob mob2 = new Mob("Rat");

            Console.WriteLine($"{player.Name} attacks {mob1.Name}\n");
            List<string> history1 = FightEngine.InitializeFight(player, mob1);
            foreach (var line in history1)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\n-------------------------------------------------");

            Console.WriteLine($"{mob2.Name} attacks {player.Name}\n");
            List<string> history2 = FightEngine.InitializeFight(mob2, player);
            foreach (var line in history2)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\n-------------------------------------------------");

            Console.WriteLine($"{player.Name} have {player.HP}HP left");
        }
    }
}
