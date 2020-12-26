using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Game
{
    /*public class monster_prop
    {
        public string name;
    }
    public class loot_prop
    {
        public string name;
    }*/
    public class cell
    {
        public string terrain;
        public string terra;
        public Mob monster;
        //public  item;
        public cell(string terrain, string terra, Mob monster)
        {
            this.terrain = terrain;
            this.terra = terra;
            this.monster = monster;
        }
    }
    public class karta
    {
        public cell[,] kart = new cell[25, 25];
        public void map_generate()
        {
            Random rand = new Random();
            Mob_Program mob_data = new Mob_Program();
            //Weapon_Program weapon_data = new Weapon_Program();
            //Armor_Program armor_data = new Armor_Program();
            //Potion new_potion = new Potion("Зелье здоровья", 5);
            int x = rand.Next(4, 19);
            int y = rand.Next(4, 19);
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (Math.Sqrt(Math.Pow(i - x, 2) + Math.Pow(j - y, 2)) <= 3)
                    {
                        switch (rand.Next(1, 5))
                        {
                            case 1:
                            case 2:
                            case 3:
                                this.kart[i, j] = new cell("Гори", "^", mob_data.mob_creation()[rand.Next(0, 5)]);
                                break;
                            case 4:
                                this.kart[i, j] = new cell("Ліс", "*", mob_data.mob_creation()[rand.Next(0, 5)]);
                                break;
                        }
                    }
                    else if (Math.Sqrt(Math.Pow(i - x, 2) + Math.Pow(j - y, 2)) <= 6)
                    {
                        switch (rand.Next(1, 5))
                        {
                            case 1:
                            case 2:
                            case 3:
                                this.kart[i, j] = new cell("Ліс", "*", mob_data.mob_creation()[rand.Next(0, 5)]);
                                break;
                            case 4:
                                this.kart[i, j] = new cell("Рівнина", "#", mob_data.mob_creation()[rand.Next(0, 5)]);
                                break;
                        }
                    }
                    else if (Math.Sqrt(Math.Pow(i - x, 2) + Math.Pow(j - y, 2)) <= 15)
                    {
                        switch (rand.Next(1, 5))
                        {
                            case 1:
                            case 2:
                            case 3:
                                this.kart[i, j] = new cell("Рівнина", "#", mob_data.mob_creation()[rand.Next(0, 5)]);
                                break;
                            case 4:
                                this.kart[i, j] = new cell("Пустеля", ".", mob_data.mob_creation()[rand.Next(0, 5)]);
                                break;
                        }
                    }
                    else if (Math.Sqrt(Math.Pow(i - x, 2) + Math.Pow(j - y, 2)) <= 20)
                    {
                        switch (rand.Next(1, 5))
                        {
                            case 1:
                            case 2:
                            case 3:
                                this.kart[i, j] = new cell("Пустеля", ".", mob_data.mob_creation()[rand.Next(0, 5)]);
                                break;
                            case 4:
                                this.kart[i, j] = new cell("Водойма", "~", mob_data.mob_creation()[rand.Next(0, 5)]);
                                break;
                        }
                    }
                    else
                    {
                        this.kart[i, j] = new cell("Водойма", "~", mob_data.mob_creation()[rand.Next(0, 5)]);
                    }
                }
            }
        }
        public void map_show(Player player)
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (player.x == i && player.y == j)
                    {
                        System.Console.Write("@");
                        System.Console.Write(' ');
                    }
                    else
                    {
                        System.Console.Write(kart[i, j].terra);
                        System.Console.Write(' ');
                    }
                }
                System.Console.Write('\n');
            }
        }
        public void map_save()
        {
            StreamWriter sw = new StreamWriter(@"D:\map.txt");
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    sw.WriteLine(kart[i, j].terrain + ' ' + kart[i, j].terra + ' ' + kart[i, j].monster.Name/* + ' ' + kart[i, j].item.name*/);                    
                }
            }
            sw.Close();
        }
        public void map_load()
        {
            StreamReader sr = new StreamReader(@"D:\map.txt");
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    string line = sr.ReadLine();
                    string[] splitLine = line.Split(' ');
                    kart[i, j].terrain = splitLine[0];
                    kart[i, j].terra = splitLine[1];
                    kart[i, j].monster.Name = splitLine[2];
                    //kart[i, j].item.name = splitLine[3];
                }
            }
            sr.Close();
        }
    }
}