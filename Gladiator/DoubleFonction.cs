using System;


namespace Gladiator
{
	public class DoubleFonction:Equipement
	{
		private double probaArretCoup;
		private double probaTouch;

		public DoubleFonction (String type, int nbPoints, double probaArretCoup, double probaTouch):base(type, nbPoints) {
			this.probaArretCoup = probaArretCoup;
			this.probaTouch = probaTouch;
		}

		public double ProbaArretCoup {
			get {
				return this.probaArretCoup;
			}
		}

		public double ProbaTouch {
			get {
				return this.probaTouch;
			}
		}
	}
}

