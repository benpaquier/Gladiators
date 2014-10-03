using System;

namespace Gladiator
{
	public class Combat
	{
		private int numDuel = 1;

		public Combat ()
		{
		}

		public void initializeDuel(Equipe equipe1, Equipe equipe2) {
			Console.WriteLine ("\n" + equipe1.Nom + " Contre " + equipe2.Nom);
			Console.WriteLine ("Duel " + numDuel);
			Console.WriteLine (equipe1.Gladiateurs[0].Nom + " VS " + equipe2.Gladiateurs[0].Nom);
		}

		public int NumDuel {
			get {
				return this.numDuel;
			}
		}
	}
}

