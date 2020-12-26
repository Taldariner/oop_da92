using System;
namespace Game
{
    public class Potion
    {
		public string name;
		public int heal_value;
		public Potion(string name, int heal_value)
		{
			this.name = name;
			this.heal_value = heal_value;
		}
		public string Description()
		{
				return $"{this.name} додає {this.heal_value} здоров'я.";
		}
	}
 }