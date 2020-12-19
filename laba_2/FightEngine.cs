using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Game
{
    public class FightEngine
    {
        public static List<string> InitializeFight(Character attacker, Character defender)
        {
            List<string> history = new List<string>();
            int dmg;

            while (attacker.IsAlive && defender.IsAlive)
            {
                dmg = attacker.ATK - defender.DEF;
                if (dmg > 0)
                {
                    defender.GetDamage(dmg);
                    history.Add($"{attacker.Name} завдає {dmg} шкоди {defender.Name}");
                }
                else
                {
                    history.Add($"{attacker.Name} не завдає шкоди {defender.Name}");
                }
                if (!defender.IsAlive)
                    break;

                dmg = defender.ATK - attacker.DEF;
                if (dmg > 0)
                {
                    attacker.GetDamage(dmg);
                    history.Add($"{defender.Name} завдає {dmg} шкоди {attacker.Name}");
                }
                else
                {
                    history.Add($"{defender.Name} не завдає шкоди {attacker.Name}");
                }
            }

            if (attacker.IsAlive)
                history.Add($"{attacker.Name} вбиває {defender.Name}");
            else
                history.Add($"{defender.Name} вбиває {attacker.Name}");

            return history;
        }
    }
}