using System;
using System.Collections.Generic;
namespace Gladiator
{
	public class ClassFunctionalities
	{
		public List<Equipe> equipes;
		public List<Gladiateur> gladiateurs;
		public List<Equipement> equipements;

		public ClassFunctionalities ()
		{
		}


		//Ratio Calcul
		public double calculPrctVictoire(int nbVictoires, int nbDefaites) {
			int totalMatchJoues = nbVictoires + nbDefaites;
			double result = (System.Convert.ToDouble(nbVictoires) / System.Convert.ToDouble(totalMatchJoues) * 100);
			return Math.Truncate(result);
		}

		//CREATION OF ALL LISTS WE NEED

		//Create team list in current player
		public List<Equipe> creerListe (Equipe equipe1) {
			List<Equipe> listequipes = new List<Equipe>(); 
			listequipes.Add (equipe1);
			return listequipes;
		}

		//Create gladiators list in current team
		public List<Gladiateur> creerListe (Gladiateur gladiateur1, Gladiateur gladiateur2, Gladiateur gladiateur3) {
			List<Gladiateur> listegladiateurs = new List<Gladiateur> ();
			listegladiateurs.Add (gladiateur1);
			listegladiateurs.Add (gladiateur2);
			listegladiateurs.Add (gladiateur3);
			return listegladiateurs;
		}

		//Create Equipement in current gladiator (with 3 items if total equipement points is <= 10)
		public List<Equipement> creerListe (Equipement equipement1, Equipement equipement2, Equipement equipement3) {
			int totalEquipementPoints = 0;
			List<Equipement> listequipements = new List<Equipement> ();
			foreach (Equipement l_equipement in listequipements) {
				totalEquipementPoints += l_equipement.NbPoints;
			}

			if (totalEquipementPoints <= 10) {
				listequipements.Add (equipement1);
				listequipements.Add (equipement2);
				listequipements.Add (equipement3);
				return listequipements;
			} else {
				Console.WriteLine ("This gladiator has too much stuff, that's over 10 points");
				return new List<Equipement> ();
			}

		}
			
		//Create Equipement in current gladiator (with 2 items if total equipement points is <= 10)
		public List<Equipement> creerListe (Equipement equipement1, Equipement equipement2) {
			int totalEquipementPoints = 0;
			List<Equipement> listequipements = new List<Equipement> ();
			foreach (Equipement l_equipement in listequipements) {
				totalEquipementPoints += l_equipement.NbPoints;
			}

			if (totalEquipementPoints <= 10) {
				listequipements.Add (equipement1);
				listequipements.Add (equipement2);
				return listequipements;
			} else { 
				Console.WriteLine ("This gladiator has too much stuff, that's over 10 points");
				return new List<Equipement> ();
			}

		}

		//Create Equipement in current gladiator (with 1 items if total equipement points is <= 10)
		public List<Equipement> creerListe (Equipement equipement1) {
			List<Equipement> listequipements = new List<Equipement> ();
			listequipements.Add (equipement1);
			return listequipements;
		}

		//ADDING ALL LIST WE HAVE TO ALL OBJECTS THAT MATCH

		//Adding team list to player
		public List<Equipe> Equipes {
			get {
				return this.equipes;
			}
		}

		public void addList (List<Equipe> p_equipes) {
			if (p_equipes.Count <= 5) {
				this.equipes = p_equipes;
			}
			else
				Console.WriteLine("Vous ne pouvez pas avoir plus de 5 équipes.");
		}

		//Adding gladiators list to team
		public List<Gladiateur> Gladiateurs {
			get {
				return this.gladiateurs;
			}
		}

		public void addList(List<Gladiateur> p_gladiateurs) {
			if (p_gladiateurs.Count <= 3) {
				this.gladiateurs = p_gladiateurs;
			}
			else 
				Console.WriteLine("Vous ne pouvez pas avoir plus de 3 gladiateurs dans une équipe. ");
		}

		//Adding equipments list to gladiator
		public List<Equipement> Equipements {
			get {
				return this.equipements;
			}
		}

		public void addList(List<Equipement> p_equipementList) {
			int totalEquipementPoint = 0;
			foreach (Equipement equipement in p_equipementList) {
				totalEquipementPoint += equipement.nbPoints;
			}
			if (totalEquipementPoint <= 10)
				this.equipements = p_equipementList;
			else
				Console.WriteLine ("Vous ne pouvez totaliser un nombre de point supérieur à 10 pour vos équipements.");
		}
	}
}

