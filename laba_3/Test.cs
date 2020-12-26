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
            Player player = new Player("");
            //player.load_player();
            Console.WriteLine("Завантажити гру(1) чи почати нову(2)?");
            int mode = Int16.Parse(Console.ReadLine());

            if(mode == 1)
            {
                mappa.map_load();
                player.load_player();
            }

            if(mode == 2)
            {
                player.Name = "Геральт";
                mappa.map_generate();
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        if(mappa.kart[i, j].terra == ".")
                        {
                            player.x = i;
                            player.y = j;
                            mappa.kart[i, j].monster = new Mob("empty", 0, 0, 0);
                            break;
                        }
                    }
                }
            }


            while(true)
            {
                int moved = 0;
                mappa.map_show(player);
                string move = Console.ReadLine();
                if(move == "w" && player.x > 0 && mappa.kart[player.x - 1, player.y].terra != "~")
                {
                    player.x -= 1;
                    if (mappa.kart[player.x, player.y].monster.Name != "empty")
                    {
                        moved = 1;
                        List<string> history1 = FightEngine.InitializeFight(player, mappa.kart[player.x, player.y].monster);
                        foreach (var line in history1)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine();
                    }
                }
                if (move == "a" && player.y > 0 && mappa.kart[player.x, player.y - 1].terra != "~")
                {
                    
                    player.y -= 1;
                    if (mappa.kart[player.x, player.y].monster.Name != "empty")
                    {
                        moved = 1;
                        List<string> history1 = FightEngine.InitializeFight(player, mappa.kart[player.x, player.y].monster);
                        foreach (var line in history1)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine();
                    }
                }
                if (move == "d" && player.y < 24 && mappa.kart[player.x, player.y + 1].terra != "~")
                {
                    player.y += 1;
                    if (mappa.kart[player.x, player.y].monster.Name != "empty")
                    {
                        moved = 1;
                        List<string> history1 = FightEngine.InitializeFight(player, mappa.kart[player.x, player.y].monster);
                        foreach (var line in history1)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine();
                    }
                }
                if (move == "s" && player.x < 24 && mappa.kart[player.x + 1, player.y].terra != "~")
                {      
                    player.x += 1;
                    if (mappa.kart[player.x, player.y].monster.Name != "empty")
                    {
                        moved = 1;
                        List<string> history1 = FightEngine.InitializeFight(player, mappa.kart[player.x, player.y].monster);
                        foreach (var line in history1)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine();
                    }
                }
                if(player.IsAlive == true && moved == 1)
                {
                    mappa.kart[player.x, player.y].monster = new Mob("empty", 0, 0, 0);
                    int loot_type = Game_God.Next(0, 3);
                    if (loot_type == 0)
                    {
                        Weapon new_weapon = weapon_data.weapon_creation()[Game_God.Next(0, 5)];
                        Console.WriteLine("Знайдена зброя " + new_weapon.name + ", що завдає до " + new_weapon.damage + " очок шкоди за удар. Спорядити?");
                        string equip_or_not = Console.ReadLine();
                        if (equip_or_not == "yes")
                        {
                            player.use(new_weapon);
                        }
                    }
                    if (loot_type == 1)
                    {
                        Armor new_armor = armor_data.armor_creation()[Game_God.Next(0, 5)];
                        Console.WriteLine("Знайдено броню " + new_armor.name + ", що поглинає " + new_armor.defence + " очок шкоди за удар. Спорядити?");
                        string equip_or_not = Console.ReadLine();
                        if( equip_or_not == "yes")
                        {
                            player.use(new_armor);
                        }
                    }
                    if (loot_type == 2)
                    {
                        Console.WriteLine("Знайдено зiлля здоров'я.");
                        player.heal_potions += 1;
                    }
                }
                if(move == "heal")
                {
                    if(player.heal_potions > 0)
                    {
                        player.use(new Potion("Зiлля здоров'я", 5));
                        player.heal_potions -= 1;
                        Console.WriteLine("Ви вiдчуваєте, як вашi рани загоюються.");
                    }
                }
                if(player.IsAlive == false)
                {
                    Console.WriteLine("Ваш герой загинув...");
                    break;
                }
                if (move == "exit")
                {
                    break;
                }
            }

            
            /*//mappa.map_load();
            mappa.map_show(player);
            //mappa.map_save();

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
            
            *//*Mob mob1 = mob_data.mob_creation()[Game_God.Next(0,5)];

            Console.WriteLine($"{player.Name} атакує {mob1.Name}\n");
            List<string> history1 = FightEngine.InitializeFight(player, mob1);
            foreach (var line in history1)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();*//*

            Console.WriteLine($"У {player.Name} залишилося {player.HP} здоров'я");
            Console.WriteLine(new_potion.Description());
            player.use(new_potion);
            Console.WriteLine($"У {player.Name} залишилося {player.HP} здоров'я\n");
            player.save_player();

            while(true)
            {

            }*/
        }
    }
}