using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Equipe: ClassFunctionalities
	{
		private String nom;
		private String description;
		private int nbMatchsJoues;
		private int nbVictoires;
		private int nbDefaites;
		public double prctVictoire;

		public Equipe ()
		{
		}

		public Equipe (String nom, String description, int nbVictoires, int nbDefaites) : this () {
			this.nom = nom;
			this.description = description;
			this.nbVictoires = nbVictoires;
			this.nbDefaites = nbDefaites;
			this.nbMatchsJoues = nbDefaites + nbVictoires;
			this.prctVictoire = calculPrctVictoire (nbVictoires, nbDefaites);
		}

		public String Nom {
			get {
				return this.nom;
			}
		}

		public String Description {
			get {
				return this.description;
			}
		}

		public int NbMatchsJoues {
			get {
				return this.nbMatchsJoues;
			}
		}

		public int NbVictoires {
			get {
				return this.nbVictoires;
			}
		}

		public int NbDefaites {
			get {
				return this.nbDefaites;
			}
		}

		public double PrctVictoire {
			get {
				return this.prctVictoire;
			}
		}




	}
}
