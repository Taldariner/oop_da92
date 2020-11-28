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
			Game.Player.Inventory.Add(new Armor("Пиво", 5));
			Game.Player.Inventory.Add(new Weapon("Ружье", 50));
			
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
