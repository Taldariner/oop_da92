using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Mob : Character
    {
        public Mob(string name)
        {
            Name = name;
            HP = 500;
            ATK = 50;
            DEF = 20;
            IsAlive = true;
        }
        public Mob(string name, int hp, int atk, int def)
        {
            Name = name;
            HP = hp;
            ATK = atk;
            DEF = def;
            IsAlive = true;
        }
    }
}
