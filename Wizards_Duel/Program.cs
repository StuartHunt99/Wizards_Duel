using System;
using System.Collections.Generic;

namespace Wizards_Duel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Wizard> Wizards = new List<Wizard>();
            Wizards.Add(new Wizard { Name = "Player 1", Health = 100 });
            Wizards.Add(new Wizard { Name = "Player 2", Health = 100 });
            string FightPrompt = "y";

            while (FightPrompt == "y")
            { 
                int hitResult = Wizards[0].CastSpell(0, 50);
                Wizards[1].Health -= hitResult;
                if (Wizards[1].Health <= 0)
                    {
                    Console.WriteLine(Wizards[1].Name + " is defeated! " + Wizards[0].Name + " is the winner!");
                    break;
                }

                Console.WriteLine(Wizards[1].Name + " has " + Wizards[1].Health + " health remaining.");


                int hitResultTwo = Wizards[1].CastSpell(0, 50);


                Wizards[0].Health -= hitResultTwo;
                if (Wizards[0].Health <= 0)
                    {
                    Console.WriteLine(Wizards[1].Name + " is defeated! " + Wizards[0].Name + " is the winner!");
                    break;
                }
                Console.WriteLine(Wizards[0].Name + " has " + Wizards[0].Health + " health remaining.");


                Console.WriteLine("Fight Again?");
                FightPrompt = Console.ReadLine();
            }
        }
    }
}

