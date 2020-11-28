using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Game
{
    public class Player : Character
    {        
        public Player(string name)
        {
            Name = name;
            HP = 1000;
            ATK = 100;
            DEF = 20;
            IsAlive = true;
        }
        public Player(string name, int hp, int atk, int def)
        {
            Name = name;
            HP = hp;
            ATK = atk;
            DEF = def;
            IsAlive = true;
        }           
    }
}