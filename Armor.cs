﻿using System;
namespace oooop
{
	public class Armor : Item, Usage
	{
		private int hpVal;

		public Armor(string name, int hpVal)
			: base(name)
		{
			this.hpVal = hpVal;
		}

		public void Use(Player p)
		{
			//p.Heal(hpVal);
		}

		public string Description
		{
			get
			{
				return $"Эта штука {this.Name} добавляет {this.hpVal} здоровья.";
			}
		}
	}
}
