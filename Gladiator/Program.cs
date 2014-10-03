using System;
using System.Collections.Generic;

namespace Gladiator
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Instanciation des 4 joueurs
			Joueur Bilbo = new Joueur("Bilbo", "", "ShireGangsta",  "02/10/2014");
			Joueur Gandalf = new Joueur("Gandalf", "", "OldyWizzard", "03/10/2014");
			Joueur Aragorn = new Joueur("Aragorn", "", "BossOfGondor", "04/10/2014");
			Joueur Sauron = new Joueur("Sauron", "", "MordorMaster", "01/10/2014");

			List<Joueur> listejoueurs = new List<Joueur>();
			listejoueurs.Add (Bilbo);
			listejoueurs.Add (Gandalf);
			listejoueurs.Add (Aragorn);
			listejoueurs.Add (Sauron);

			//4 équipes
			Equipe ShireHood = new Equipe("ShireHood", "Don't mess with hairy feet", 63, 46);
			Equipe IstariRoxx = new Equipe ("IstariRoxx", "Old fellows that rox", 132445, 7);
			Equipe WhiteTower4Ever = new Equipe ("WhiteTower4Ever", "Mortal but invincible", 398, 224);
			Equipe EvilIsLife = new Equipe ("EvilIsLife", "We torture you all", 49566, 10439);

			//Creation des gladiateurs

			//Bilbo's team
			Gladiateur Frodo = new Gladiateur (1, "Frodo", 33, 12);
			Gladiateur Sam = new Gladiateur (2, "Sam", 29, 1);
			Gladiateur Gollum = new Gladiateur (3, "Gollum", 1, 33);

			//Gandalf's team
			Gladiateur Saruman = new Gladiateur (1, "Saruman", 20405, 7);
			Gladiateur Eru_Illuvatar = new Gladiateur (2, "Eru Illuvatar", 110040, 0);
			Gladiateur Radagast = new Gladiateur (3, "Radagast", 2000, 0);

			//Aragorn's team
			Gladiateur Isildur = new Gladiateur (1, "Isildur", 258, 54);
			Gladiateur Boromir = new Gladiateur (2, "Boromir", 60, 100);
			Gladiateur Faramir = new Gladiateur (3, "Faramir", 80, 70);

			//Sauron's team
			Gladiateur WitchKing = new Gladiateur (1, "WitchKing", 29566, 439);
			Gladiateur Mumakil = new Gladiateur (2, "Mumakil", 1000, 6000);
			Gladiateur JustAnOrc = new Gladiateur (3, "JustAnOrc", 10000, 4000);

			//Setting Weapon to gladiators
			Frodo.addList (Frodo.creerListe (Equipement.dague, Equipement.epee));
			Sam.addList (Sam.creerListe (Equipement.lance, Equipement.casque));
			Gollum.addList (Gollum.creerListe (Equipement.filet, Equipement.trident));

			Saruman.addList (Saruman.creerListe(Equipement.trident));
			Eru_Illuvatar.addList (Eru_Illuvatar.creerListe (Equipement.bouclierRect, Equipement.dague));
			Radagast.addList (Radagast.creerListe (Equipement.filet, Equipement.petitBouclier));

			Isildur.addList (Isildur.creerListe (Equipement.epee, Equipement.dague));
			Boromir.addList (Boromir.creerListe (Equipement.epee, Equipement.petitBouclier));
			Faramir.addList (Faramir.creerListe (Equipement.filet, Equipement.dague));

			WitchKing.addList (WitchKing.creerListe (Equipement.trident, Equipement.casque));
			Mumakil.addList (Mumakil.creerListe (Equipement.bouclierRect, Equipement.dague));
			JustAnOrc.addList (JustAnOrc.creerListe (Equipement.casque, Equipement.dague, Equipement.petitBouclier));

			//Ajout des gladiateurs dans les équipes
			ShireHood.addList (ShireHood.creerListe (Frodo, Sam, Gollum));
			IstariRoxx.addList (IstariRoxx.creerListe (Saruman, Eru_Illuvatar, Radagast));
			WhiteTower4Ever.addList (WhiteTower4Ever.creerListe (Isildur, Boromir, Faramir));
			EvilIsLife.addList (EvilIsLife.creerListe (WitchKing, Mumakil, JustAnOrc));

			//Ajout des équipes dans les joueurs
			Bilbo.addList (Bilbo.creerListe (ShireHood));
			Gandalf.addList (Gandalf.creerListe (IstariRoxx));
			Aragorn.addList (Aragorn.creerListe (WhiteTower4Ever));
			Sauron.addList (Sauron.creerListe (EvilIsLife));

			Tournoi tournoi = new Tournoi ();
			List<Equipe> allTeam = tournoi.initializeTeamOrder (listejoueurs);
			Console.WriteLine ("\nDébut des combats");
			Combat duel = new Combat ();
			duel.initializeDuel (allTeam[0], allTeam[1]);


			//Initialiser un duel avec les premiers gladiateurs


		}
	}
}