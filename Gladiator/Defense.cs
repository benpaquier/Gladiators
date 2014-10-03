using System;

namespace Gladiator
{
	public class Defense:Equipement
	{
		private double probaArretCoup;

		public Defense (String type, int nbPoints, double probaArretCoup):base(type, nbPoints) {
			this.probaArretCoup = probaArretCoup;
		}

		public double ProbaArretCoup {
			get {
				return this.probaArretCoup;
			}
		}
	}
}
