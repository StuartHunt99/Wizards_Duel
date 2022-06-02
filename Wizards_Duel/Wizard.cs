using System;

namespace Wizards_Duel
{
	public class Wizard
	{
		public string Name;
		public int Health;
		public int CastSpell(int low, int high)
		{
			
			Random numberGen = new Random();
			int hitCount = numberGen.Next(low, high);
            Console.WriteLine(Name + " attacked with " + hitCount + " damage!");
			return hitCount;
		}
	}
}

