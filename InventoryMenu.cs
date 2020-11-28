using System;
using System.Collections.Generic;

namespace oooop
{
	public static class InventoryMenu
	{
		public static void Controll(ConsoleKeyInfo e)
		{
			switch (e.Key)
			{
				case ConsoleKey.UpArrow:
					if (Game.Selection != 0)
					{
						Game.Selection--;
					}
					break;

				case ConsoleKey.DownArrow:
					if (Game.Selection < Game.Player.Inventory.Count - 1)
					{
						Game.Selection++;
					}
					break;

				case ConsoleKey.E:
					Game.Player.Use(Game.Selection);
					Game.Selection = 0;
					break;

				case ConsoleKey.Escape:
					Close();
					break;
			}


		}

		public static void Open()
		{
			if (Game.Player.Inventory.Count > 0)
			{
				Game.Mode = GameMode.Inventory;
				Game.Selection = 0;
			}
			else
			{
				Console.WriteLine("Your inventory is empty! ");
				Console.ReadKey();
			}
		}

		public static void Close()
		{
			Game.Selection = -1;
			//Game.Mode = GameMode.Location;
		}

	}
}
