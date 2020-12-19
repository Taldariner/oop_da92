using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Mob : Character
    {
        public Mob(string name, int hp, int atk, int def)
        {
            Name = name;
            HP = hp;
            ATK = atk;
            DEF = def;
            IsAlive = true;
        }
    }
    public class Mob_Program
    {
        public Mob[] mob_creation()
        {
            Mob[] mob_library = new Mob[5];
            mob_library[0] = new Mob("Зомбi", 15, 5, 5);
            mob_library[1] = new Mob("Гоблiн", 15, 10, 0);
            mob_library[2] = new Mob("Орк", 25, 10, 5);
            mob_library[3] = new Mob("Скелет", 25, 5, 5);
            mob_library[4] = new Mob("Голем", 35, 5, 10);
            return mob_library;
        }
    }
}