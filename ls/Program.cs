using System;
using System.Collections.Generic;


namespace oooop
{
    class Program
    {
		static void Main(string[] args)
		{
			InitGame();
			Update();
		}

		static void InitGame()
		{
			Game.Player = new Player("Lisa");
			Game.Objects.Add(Game.Player);
			Game.Player.Inventory.Add(new Armor("Щит", 1.2));
			Game.Player.Inventory.Add(new Armor("Ботинки", 1.1));
			Game.Player.Inventory.Add(new Weapon("Ружье", 20));
			Game.Player.Inventory.Add(new Weapon("Палка", 8));
			Game.Player.Inventory.Add(new Weapon("Камень", 15));
			Game.Player.Inventory.Add(new Potion("Пиво", 5));
			Game.Player.Inventory.Add(new Potion("Хлеб", 10));
			
		}

		static void Update()
		{
			ConsoleKeyInfo e;

			while (Game.Play)
			{
				switch (Game.Mode)
				{
					//case GameMode.Location:
						

					case GameMode.Inventory:

						if (Game.Player.Inventory.Count == 0)
						{
							InventoryMenu.Close();
							break;
						}

						Menu.DrawInventory(Game.Player.Inventory);

						e = Console.ReadKey();

						InventoryMenu.Controll(e);
						break;
				}


			}
		}
	}
}
