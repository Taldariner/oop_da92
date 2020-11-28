using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Map
{
    public class monster_prop
    {
        public string name;
    }
    public class loot_prop
    {
        public string name;
    }
    public class cell
    {
        public string terrain;
        public string terra;
        //public string mob;
        //public string loot;
        public monster_prop monster;
        public loot_prop item;
    }
    public class karta
    {
        public string[] terrain_list = {"Водоём", "Пустыня", "Равнина", "Лес", "Горы"};
        public string[] terra_list = { "~", ".", "#", "*", "^"};
        public string[] mob_list = { "Зомби", "Гоблин", "Орк"};
        public string[] loot_list = { "Железный меч", "Кожаная броня", "Дубинка", "Кожаный шлем", "Железное копьё" };
        public cell[,] kart = new cell[25, 25];
        public void map_generate()
        {
            Random rand = new Random();
            int x = rand.Next(4, 19);
            int y = rand.Next(4, 19);
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    this.kart[i, j] = new cell();
                    if (Math.Sqrt(Math.Pow(i - x, 2) + Math.Pow(j - y, 2)) <= 3)
                    {
                        switch (rand.Next(1, 5))
                        {
                            case 1:
                                this.kart[i, j].terrain = "Горы";
                                this.kart[i, j].terra = "^";
                                break;
                            case 2:
                                this.kart[i, j].terrain = "Горы";
                                this.kart[i, j].terra = "^";
                                break;
                            case 3:
                                this.kart[i, j].terrain = "Горы";
                                this.kart[i, j].terra = "^";
                                break;
                            case 4:
                                this.kart[i, j].terrain = "Лес";
                                this.kart[i, j].terra = "*";
                                break;
                        }
                    }
                    else if (Math.Sqrt(Math.Pow(i - x, 2) + Math.Pow(j - y, 2)) <= 6)
                    {
                        switch (rand.Next(1, 5))
                        {
                            case 1:
                                this.kart[i, j].terrain = "Лес";
                                this.kart[i, j].terra = "*";
                                break;
                            case 2:
                                this.kart[i, j].terrain = "Лес";
                                this.kart[i, j].terra = "*";
                                break;
                            case 3:
                                this.kart[i, j].terrain = "Лес";
                                this.kart[i, j].terra = "*";
                                break;
                            case 4:
                                this.kart[i, j].terrain = "Равнина";
                                this.kart[i, j].terra = "#";
                                break;
                        }
                    }
                    else if (Math.Sqrt(Math.Pow(i - x, 2) + Math.Pow(j - y, 2)) <= 15)
                    {
                        switch (rand.Next(1, 5))
                        {
                            case 1:
                                this.kart[i, j].terrain = "Равнина";
                                this.kart[i, j].terra = "#";
                                break;
                            case 2:
                                this.kart[i, j].terrain = "Равнина";
                                this.kart[i, j].terra = "#";
                                break;
                            case 3:
                                this.kart[i, j].terrain = "Равнина";
                                this.kart[i, j].terra = "#";
                                break;
                            case 4:
                                this.kart[i, j].terrain = "Пустыня";
                                this.kart[i, j].terra = ".";
                                break;
                        }
                    }
                    else if (Math.Sqrt(Math.Pow(i - x, 2) + Math.Pow(j - y, 2)) <= 20)
                    {
                        switch (rand.Next(1, 5))
                        {
                            case 1:
                                this.kart[i, j].terrain = "Пустыня";
                                this.kart[i, j].terra = ".";
                                break;
                            case 2:
                                this.kart[i, j].terrain = "Пустыня";
                                this.kart[i, j].terra = ".";
                                break;
                            case 3:
                                this.kart[i, j].terrain = "Пустыня";
                                this.kart[i, j].terra = ".";
                                break;
                            case 4:
                                this.kart[i, j].terrain = "Водоём";
                                this.kart[i, j].terra = "~";
                                break;
                        }
                    }
                    else
                    {
                        kart[i, j].terrain = "Водоём";
                        kart[i, j].terra = "~";
                    }
                    //this.kart[i, j].mob = mob_list[rand.Next(0, mob_list.Length)];
                    //this.kart[i, j].loot = loot_list[rand.Next(0, loot_list.Length)];
                    this.kart[i, j].monster = new monster_prop();
                    this.kart[i, j].item = new loot_prop();
                    this.kart[i, j].monster.name = mob_list[rand.Next(0, mob_list.Length)];
                    this.kart[i, j].item.name = loot_list[rand.Next(0, loot_list.Length)];
                }
            }
        }
        public void map_show()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    System.Console.Write(kart[i, j].terra);
                    System.Console.Write(' ');
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
                    sw.WriteLine(kart[i, j].terrain + ' ' + kart[i, j].terra + ' ' + kart[i, j].monster.name + ' ' + kart[i, j].item.name);                    
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
                    kart[i, j].monster.name = splitLine[2];
                    kart[i, j].item.name = splitLine[3];
                }
            }
            sr.Close();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            karta mappa = new karta();
            mappa.map_generate();
            mappa.map_show();
            System.Console.WriteLine("Hello World!");
            mappa.map_save();
            mappa.map_load();
            mappa.map_show();
            System.Console.WriteLine("Hello World!");
        }
    }
}