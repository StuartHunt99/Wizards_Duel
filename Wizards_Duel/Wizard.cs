using System;

namespace Wizards_Duel
{
	public class Wizard
	{
		public int health = 0;
		public void CastSpell(int low, int high)
		{
			Random numberGen = new Random();
			int hitCount = numberGen.Next(low, high);
            Console.WriteLine("You attacked with " + hitCount + " damage!");
		}
	}
}

