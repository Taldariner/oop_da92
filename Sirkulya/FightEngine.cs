using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
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
                    defender.GetDamage(dmg);

                history.Add($"{attacker.Name} dealt {dmg} damage to {defender.Name}");

                if (!defender.IsAlive)
                    break;

                dmg = defender.ATK - attacker.DEF;

                if (dmg > 0)
                    attacker.GetDamage(dmg);

                history.Add($"{defender.Name} dealt {dmg} damage to {attacker.Name}");
            }

            if (attacker.IsAlive)
                history.Add($"{attacker.Name} killed {defender.Name}");
            else
                history.Add($"{defender.Name} killed {attacker.Name}");

            return history;
        }
    }
}