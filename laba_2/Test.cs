using System;
using System.Collections.Generic;

namespace Game
{
    class Test
    {
        static void Main(string[] args)
        {
            Random Game_God = new Random();
            Mob_Program mob_data = new Mob_Program();
            Weapon_Program weapon_data = new Weapon_Program();
            Armor_Program armor_data = new Armor_Program();
            Potion new_potion = new Potion("Зiлля здоров'я", 5);

            karta mappa = new karta();
            mappa.map_generate();
            mappa.map_load();
            mappa.map_show();
            mappa.map_save();

            Player player = new Player("Геральт");
            player.load_player();
            
            Console.WriteLine();
            Console.WriteLine($"{player.Name}");
            Console.WriteLine($"{player.HP}");
            Console.WriteLine($"{player.current_weapon.name}");
            Console.WriteLine($"{player.current_armor.name}");
            Console.WriteLine();

            Weapon weapon1 = weapon_data.weapon_creation()[Game_God.Next(0, 5)];
            Armor armor1 = armor_data.armor_creation()[Game_God.Next(0, 5)];
            player.use(weapon1);
            player.use(armor1);

            Console.WriteLine($"{player.Name}");
            Console.WriteLine($"{player.current_weapon.name}");
            Console.WriteLine($"{player.current_armor.name}");
            Console.WriteLine();
            
            Mob mob1 = mob_data.mob_creation()[Game_God.Next(0,5)];

            Console.WriteLine($"{player.Name} атакує {mob1.Name}\n");
            List<string> history1 = FightEngine.InitializeFight(player, mob1);
            foreach (var line in history1)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine($"У {player.Name} залишилося {player.HP} здоров'я");
            Console.WriteLine(new_potion.Description());
            player.use(new_potion);
            Console.WriteLine($"У {player.Name} залишилося {player.HP} здоров'я\n");
            player.save_player();
        }
    }
}