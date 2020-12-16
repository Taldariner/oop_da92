using System;
namespace oooop
{
    public class Potion: Item, Usage
    {
        
        
			private int hpVal;

		public Potion(string name, int hpVal)
			: base(name)

		{
			this.hpVal = hpVal;
		}

		public void Use(Player p)
		{
			p.Heal(hpVal);
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

