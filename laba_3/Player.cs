using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Game
{
    public class Player : Character
    {
        public int x;
        public int y;
        public Weapon current_weapon;
        public Armor current_armor;
        public int heal_potions;

        public Player(string name)
        {
            current_weapon = new Weapon("Кийок", 5);
            current_armor = new Armor("Сорочка", 0);
            heal_potions = 0;
            ATK = 5;
            DEF = 0;
            Name = name;
            HP = 100;
            IsAlive = true;
        }
        public void use(Weapon new_weapon)
        {
            current_weapon = new_weapon;
            ATK = current_weapon.damage;
        }
        public void use(Armor new_armor)
        {
            current_armor = new_armor;
            DEF = current_armor.defence;
        }
        public void use(Potion new_potion)
        {
            HP += new_potion.heal_value;
        }
        public void save_player()
        {
            StreamWriter sw = new StreamWriter(@"D:\hero.txt");
            sw.WriteLine(Name);
            sw.WriteLine(HP);
            sw.WriteLine(x);
            sw.WriteLine(y);
            sw.WriteLine(current_weapon.name);
            sw.WriteLine(current_weapon.damage);
            sw.WriteLine(current_armor.name);
            sw.WriteLine(current_armor.defence);
            sw.Close();
        }
        public void load_player()
        {
            StreamReader sr = new StreamReader(@"D:\hero.txt");
            Name = sr.ReadLine();
            HP = Int16.Parse(sr.ReadLine());
            x = Int16.Parse(sr.ReadLine());
            y = Int16.Parse(sr.ReadLine());
            use(new Weapon(sr.ReadLine(), Int16.Parse(sr.ReadLine())));
            use(new Armor(sr.ReadLine(), Int16.Parse(sr.ReadLine())));
            sr.Close();
        }
    }
}