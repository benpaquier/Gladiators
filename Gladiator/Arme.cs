using System;

namespace Gladiator
{
	public class Arme:Equipement
	{
		private double probaTouch;

		public Arme (String type, int nbPoints, double probaTouch):base(type, nbPoints) {
			this.probaTouch = probaTouch;
		}

		public double ProbaTouch {
			get {
				return this.probaTouch;
			}
		}
	}
}

