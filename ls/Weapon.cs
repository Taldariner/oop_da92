using System;
namespace oooop
{
    public class Weapon : Item, IWearable
 	{
		 private int damage;

 		public Weapon(string name, int damage)
 			:base(name)
 		{
			 this.damage = damage;
 		}

 		public void Wear(Player p)
 		{
			 
 		}
 }

