using System;
using System.Collections.Generic;
using System.Linq;

namespace Gladiator
{
	public class Tournoi
	{
		public Tournoi ()
		{
		}

		public List<Equipe> initializeTeamOrder(List<Joueur> allPlayer) {
			List<Equipe> allTeam = new List<Equipe> ();

			foreach (Joueur player in allPlayer) {
				allTeam.Add(player.Equipes[0]);
			}

			allTeam = (from team in allTeam
				orderby team.prctVictoire descending
			           select team).ToList ();

			Console.WriteLine ("TEAM ORDER: ");

			foreach (Equipe team in allTeam)
				Console.WriteLine (team.Nom + " " + team.PrctVictoire);

			Console.WriteLine ("\nLe tournoi commence, les combats suivant vont avoir lieu: ");
			Console.WriteLine ("\t- " + allTeam [0].Nom + " VS " + allTeam [1].Nom);
			Console.WriteLine ("\t- " + allTeam [2].Nom + " VS " + allTeam [3].Nom);

			return allTeam;
				
		}


//		public List<Equipe> initializeTeamOrder(Equipe first, Equipe second, Equipe third, Equipe fourth) {
//			List<Equipe> allTeam = new List<Equipe> ();
//			allTeam.Add (first);
//			allTeam.Add (second);
//			allTeam.Add (third);
//			allTeam.Add (fourth);
//
//			allTeam = (from team in allTeam
//				orderby team.prctVictoire descending
//			           select team).ToList ();
//
//			Console.WriteLine ("TEAM ORDER: ");
//
//			foreach (Equipe team in allTeam)
//				Console.WriteLine (team.Nom + " " + team.PrctVictoire);
//
//			Console.WriteLine ("\nLe tournoi commence, les combats suivant vont avoir lieu: ");
//			Console.WriteLine ("\t- " + allTeam [0].Nom + " VS " + allTeam [1].Nom);
//			Console.WriteLine ("\t- " + allTeam [2].Nom + " VS " + allTeam [3].Nom);
//
//			return allTeam;
//		}
	}
}

