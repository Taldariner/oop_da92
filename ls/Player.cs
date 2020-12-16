using System;
using System.Collections.Generic;

namespace oooop
{
	public class Player : GameObject
	{

		private List<Item> inventory;

		public Player(string name)
			: base(name)
		{
			inventory = new List<Item>();
		}

		public void Use(int index)
		{
			if (inventory[index] is IUsable)
			{
				Usage item = inventory[index] as Usage;
				item.Use(this);

				inventory.RemoveAt(index);
			}
			
			else if(inventory[index] is IWearable)
 			{
 				IWearable item = inventory[index] as IWearable;
 				item.Wear(this);

 				inventory.RemoveAt(index);
 			}
			
			else
			{
				Console.WriteLine("You can't use that!");
			}
		}

		public List<Item> Inventory
		{
			get
			{
				return this.inventory;
			}
		}
	}
}
