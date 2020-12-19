using System;

namespace Game
{
    public class Armor
    {
        public string name;
        public int defence;
        public Armor(string name, int defence)
        {
            this.name = name;
            this.defence = defence;
        }
    }
	public class Armor_Program
	{
		public Armor[] armor_creation()
		{
			Armor[] armor_library = new Armor[5];
			armor_library[0] = new Armor("Шкiрянка", 1);
			armor_library[1] = new Armor("Кольчуга", 2);
			armor_library[2] = new Armor("Кiраса", 4);
			armor_library[3] = new Armor("Пластинчаста броня", 3);
			armor_library[4] = new Armor("Мiфриловий обладунок", 5);
			return armor_library;
		}
	}
}