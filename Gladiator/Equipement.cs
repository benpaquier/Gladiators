using System;

namespace Gladiator
{
	public class Equipement
	{
		protected String type;
		public int nbPoints;

		public static Equipement petitBouclier = new Defense ("Petit Bouclier Rond", 5, 0.2);
		public static Equipement bouclierRect = new Defense ("Bouclier Rectangulaire", 8, 0.3);
		public static Equipement casque = new Defense ("Casque", 2, 0.1);
		public static Equipement dague = new Arme ("Dague", 2, 0.6);
		public static Equipement epee = new Arme ("Epee", 5, 0.7);
		public static Equipement lance = new Arme ("Lance", 7, 0.5);
		public static Equipement filet = new Arme ("Filet", 3, 0.30);
		public static Equipement trident = new DoubleFonction ("Trident", 7, 0.1, 0.4);

		public Equipement ()
		{
		}

		public Equipement (String type, int nbPoints):this() {
			this.type = type;
			this.nbPoints = nbPoints;
		}

		public String Type {
			get {
				return this.type;
			}
		}

		public int NbPoints {
			get {
				return this.nbPoints;
			}
		}
	}
}
