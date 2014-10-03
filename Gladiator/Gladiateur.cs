using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Gladiateur: ClassFunctionalities
	{
		private int position;
		private string nom;
		public int nbVictoires;
		private int nbDefaites;
		private double prctVictoire;

		public Gladiateur ()
		{
		}

		public Gladiateur(int position, String nom, int nbVictoires, int nbDefaites):this() {
			this.position = position;
			this.nom = nom;
			this.nbVictoires = nbVictoires;
			this.nbDefaites = nbDefaites;
			this.prctVictoire = calculPrctVictoire (nbVictoires, nbDefaites);
		}

		public int Position {
			get {
				return position;
			}
		}			

		public string Nom {
			get {
				return this.nom;
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

