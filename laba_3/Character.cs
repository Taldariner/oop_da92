using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public abstract class Character
    {
        public string Name;
        public int HP;
        public int ATK;
        public int DEF;
        public bool IsAlive;

        public void GetDamage(int dmg)
        {
            HP -= dmg;

            if (HP <= 0)
                IsAlive = false;
        }
    }
}