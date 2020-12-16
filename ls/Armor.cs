using System;
namespace oooop
{
    public class Armor : Item, IWearable
 	{
		 private int damage_coeff;
		 
 		public Weapon(string name, int damage_coeff)
 			:base(name)
 		{
			 this.damage_coeff = damage_coeff;
 		}

 		public void Wear(Player p)
 		{
			 
 		}
 }
