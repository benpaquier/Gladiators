using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Joueur: ClassFunctionalities
	{
		private String prenom;
		private String nom;
		private String pseudo;
		private String inscriptionDate;

		// CONSTRUCTORS //

		public Joueur ()
		{
		}

			public Joueur (String prenom, String nom, String pseudo, String inscriptionDate):this() {
			this.prenom = prenom;
			this.nom = nom;
			this.pseudo = pseudo;
			this.inscriptionDate = inscriptionDate;
		}
			
		//Ajoute la liste crée juste avant dans le joueur

			

		// GETTER SETTER //

		public String Prenom {
			get {
				return this.prenom;
			}
		}

		public String Nom {
			get {
				return this.nom;
			}
		}

		public String Pseudo {
			get {
				return this.pseudo;
			}
		}


		public String InscriptionDate {
			get {
					return this.inscriptionDate;
			}
		}
	}
}