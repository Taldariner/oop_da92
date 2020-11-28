using System;
using System.Collections.Generic;

namespace oooop
{
    public static class Menu
    {
		public static void Draw(List<GameObject> objects)
		{
			Console.Clear();

		}



		public static void DrawInventory(List<Item> items)
		{
			Console.Clear();

			Console.SetCursorPosition(0, 0);

			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("Inventory");

			for (int i = 0; i < items.Count; i++)
			{
				Console.ForegroundColor = ConsoleColor.Gray;

				if (i == Game.Selection)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
				}

				Console.WriteLine(items[i].Name);
			}

			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
