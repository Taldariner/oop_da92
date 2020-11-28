using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public abstract class Character
    {
        public string Name { get; protected set; }
        public int HP { get; protected set; }
        public int ATK { get; protected set; }
        public int DEF { get; protected set; }
        public bool IsAlive { get; protected set; }

        public void GetDamage(int dmg)
        {
            HP -= dmg;

            if (HP <= 0)
                IsAlive = false;
        }
    }
}
