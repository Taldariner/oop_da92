using System;
using System.Collections.Generic;

namespace oooop
{
	public static class Game
	{
		public static bool Play = true;
		public static List<GameObject> Objects = new List<GameObject>();
		public static Player Player;
		public static GameMode Mode = GameMode.Inventory;
		public static int Selection = -1;
	}
}
