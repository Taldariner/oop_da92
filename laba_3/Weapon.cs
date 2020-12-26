using System;

namespace Game
{
	public class Weapon
	{
		public int damage;
		public string name;
		public Weapon(string name, int damage)
		{
			this.name = name;
			this.damage = damage;
		}
	}

	public class Weapon_Program
	{
		public Weapon[] weapon_creation()
		{
			Weapon[] weapon_library = new Weapon[5];
			weapon_library[0] = new Weapon("Меч", 10);
			weapon_library[1] = new Weapon("Секира", 15);
			weapon_library[2] = new Weapon("Лук", 13);
			weapon_library[3] = new Weapon("Алебарда", 20);
			weapon_library[4] = new Weapon("Клеймор", 17);
			return weapon_library;
		}
	}
}